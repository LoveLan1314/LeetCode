using System;

namespace LeetCode.SAOA
{
    internal sealed class Offer42_MaxSubArraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            int pre = 0;
            int maxAns = nums[0];
            foreach (var item in nums)
            {
                pre = Math.Max(pre + item, item);
                maxAns = Math.Max(maxAns, pre);
            }
            return maxAns;
        }
    }
}
