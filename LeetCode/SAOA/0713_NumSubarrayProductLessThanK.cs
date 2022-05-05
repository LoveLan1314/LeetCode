﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class NumSubarrayProductLessThanKSolution
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int n = nums.Length, ret = 0;
            int prod = 1, i = 0;
            for (int j = 0; j < n; j++)
            {
                prod *= nums[j];
                while (i <= j && prod >= k)
                {
                    prod /= nums[i];
                    i++;
                }
                ret += j - i + 1;
            }
            return ret;
        }
    }
}
