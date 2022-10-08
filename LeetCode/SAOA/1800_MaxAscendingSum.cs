using System;

namespace LeetCode.SAOA
{
    internal sealed class MaxAscendingSumSolution
    {
        public int MaxAscendingSum(int[] nums)
        {
            var max = int.MinValue;
            var current = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    current += nums[i];
                }
                else
                {
                    max = Math.Max(max, current);
                    current = nums[i];
                }
            }
            max = Math.Max(max, current);
            return max;
        }
    }
}
