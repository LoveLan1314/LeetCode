﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class IsIdealPermutationSolution
    {
        public bool IsIdealPermutation(int[] nums)
        {
            int n = nums.Length, minSuff = nums[n - 1];
            for (int i = n - 3; i >= 0; i--)
            {
                if (nums[i] > minSuff)
                {
                    return false;
                }
                minSuff = Math.Min(minSuff, nums[i + 1]);
            }
            return true;
        }
    }
}
