﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class MinSwapSolution
    {
        public int MinSwap(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int a = 0, b = 1;
            for (int i = 1; i < n; i++)
            {
                int at = a, bt = b;
                a = b = n;
                if (nums1[i] > nums1[i - 1] && nums2[i] > nums2[i - 1])
                {
                    a = Math.Min(a, at);
                    b = Math.Min(b, bt + 1);
                }
                if (nums1[i] > nums2[i - 1] && nums2[i] > nums1[i - 1])
                {
                    a = Math.Min(a, bt);
                    b = Math.Min(b, at + 1);
                }
            }
            return Math.Min(a, b);
        }
    }
}
