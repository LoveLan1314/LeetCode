﻿namespace LeetCode.SAOA
{
    internal sealed class NumSubarrayBoundedMaxSolution
    {
        public int NumSubarrayBoundedMax(int[] nums, int left, int right)
        {
            int res = 0, last2 = -1, last1 = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= left && nums[i] <= right)
                {
                    last1 = i;
                }
                else if (nums[i] > right)
                {
                    last2 = i;
                    last1 = -1;
                }
                if (last1 != -1)
                {
                    res += last1 - last2;
                }
            }
            return res;
        }
    }
}
