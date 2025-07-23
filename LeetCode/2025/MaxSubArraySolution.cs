using System;

namespace LeetCode._2025
{
    internal sealed class MaxSubArraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            int pre = 0, maxAns = nums[0];
            foreach (int x in nums)
            {
                pre = Math.Max(pre + x, x);
                maxAns = Math.Max(maxAns, pre);
            }
            return maxAns;
        }
    }
}
