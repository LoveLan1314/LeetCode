﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class SpecialArraySolution
    {
        public int SpecialArray(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            for (int i = 1; i <= n; ++i)
            {
                if (nums[i - 1] >= i && (i == n || nums[i] < i))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
