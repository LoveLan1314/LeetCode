﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class MinMoves2Solution
    {
        public int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length, ret = 0, x = nums[n / 2];
            for (int i = 0; i < n; i++)
            {
                ret += Math.Abs(nums[i] - x);
            }
            return ret;
        }
    }
}
