using System;

namespace LeetCode.SAOA
{
    internal sealed class MinPairSumSolution
    {
        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums.Length - 1;
            int result = int.MinValue;
            while (left < right)
            {
                result = Math.Max(result, nums[left] + nums[right]);
                left++;
                right--;
            }
            return result;
        }
    }
}
