using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class ContainsNearbyAlmostDuplicateSolution3
    {
        //超时
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length && j <= i + k; j++)
                {
                    if (Math.Abs((long)nums[i] - nums[j]) <= t)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ContainsNearbyAlmostDuplicate2(int[] nums, int k, int t)
        {
            int n = nums.Length;
            Dictionary<long, long> map = new Dictionary<long, long>();
            long w = t + 1;
            for (int i = 0; i < n; i++)
            {
                long id = GetId(nums[i], w);
                if (map.ContainsKey(id))
                {
                    return true;
                }
                if (map.TryGetValue(id - 1, out var value))
                {
                    if (Math.Abs(nums[i] - value) < w)
                    {
                        return true;
                    }
                }
                if (map.TryGetValue(id + 1, out value))
                {
                    if (Math.Abs(nums[i] - value) < w)
                    {
                        return true;
                    }
                }
                map.Add(id, nums[i]);
                if (i >= k)
                {
                    map.Remove(GetId(nums[i - k], w));
                }
            }
            return false;
        }

        private long GetId(long x, long w)
        {
            if (x >= 0)
            {
                return x / w;
            }
            else
            {
                return (x + 1) / w - 1;
            }
        }
    }
}
