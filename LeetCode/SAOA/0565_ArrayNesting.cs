﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class ArrayNestingSolution
    {
        public int ArrayNesting(int[] nums)
        {
            int ans = 0, n = nums.Length;
            bool[] vis = new bool[n];
            for (int i = 0; i < n; ++i)
            {
                int cnt = 0;
                while (!vis[i])
                {
                    vis[i] = true;
                    i = nums[i];
                    ++cnt;
                }
                ans = Math.Max(ans, cnt);
            }
            return ans;
        }
    }
}
