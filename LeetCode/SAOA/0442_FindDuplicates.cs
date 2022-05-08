using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindDuplicatesSolution
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            int n = nums.Length;
            var ans = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                int x = Math.Abs(nums[i]);
                if (nums[x - 1] > 0)
                {
                    nums[x - 1] = -nums[x - 1];
                }
                else
                {
                    ans.Add(x);
                }
            }
            return ans;
        }
    }
}
