using System;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class CanPartitionKSubsetsSolution
    {
        private int[] _nums;
        private int _per, _n;
        private bool[] _dp;

        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            this._nums = nums;
            int all = nums.Sum();
            if (all % k != 0)
            {
                return false;
            }
            _per = all / k;
            Array.Sort(nums);
            _n = nums.Length;
            if (nums[_n - 1] > _per)
            {
                return false;
            }
            _dp = new bool[1 << _n];
            Array.Fill(_dp, true);
            return DFS((1 << _n) - 1, 0);
        }

        private bool DFS(int s, int p)
        {
            if (s == 0)
            {
                return true;
            }
            if (!_dp[s])
            {
                return _dp[s];
            }
            _dp[s] = false;
            for (int i = 0; i < _n; i++)
            {
                if (_nums[i] + p > _per)
                {
                    break;
                }
                if (((s >> i) & 1) != 0)
                {
                    if (DFS(s ^ (1 << i), (p + _nums[i]) % _per))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
