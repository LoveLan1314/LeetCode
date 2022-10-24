using System;

namespace LeetCode.SAOA
{
    internal sealed class PartitionDisjointSolution
    {
        public int PartitionDisjoint(int[] nums)
        {
            int n = nums.Length;
            int[] minRight = new int[n];
            minRight[n - 1] = nums[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                minRight[i] = Math.Min(nums[i], minRight[i + 1]);
            }

            int maxLeft = 0;
            for (int i = 0; i < n - 1; i++)
            {
                maxLeft = Math.Max(maxLeft, nums[i]);
                if (maxLeft <= minRight[i + 1])
                {
                    return i + 1;
                }
            }
            return n - 1;
        }
    }
}
