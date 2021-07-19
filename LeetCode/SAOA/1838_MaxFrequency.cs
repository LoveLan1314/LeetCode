using System;

namespace LeetCode.SAOA
{
    internal sealed class MaxFrequencySolution
    {
        public int MaxFrequency(int[] nums, int k)
        {
            Array.Sort(nums);
            long total = 0;
            int result = 1;
            int l = 0;
            for (int r = 1; r < nums.Length; r++)
            {
                total += (long)(nums[r] - nums[r - 1]) * (r - l);
                while (total > k)
                {
                    total -= nums[r] - nums[l];
                    l++;
                }
                result = Math.Max(result, r - l + 1);
            }
            return result;
        }
    }
}
