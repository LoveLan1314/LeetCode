﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class MinFlipsMonoIncrSolution
    {
        public int MinFlipsMonoIncr(string s)
        {
            int n = s.Length;
            int dp0 = 0, dp1 = 0;
            for (int i = 0; i < n; i++)
            {
                char c = s[i];
                int dp0New = dp0, dp1New = Math.Min(dp0, dp1);
                if (c == '1')
                {
                    dp0New++;
                }
                else
                {
                    dp1New++;
                }
                dp0 = dp0New;
                dp1 = dp1New;
            }
            return Math.Min(dp0, dp1);
        }
    }
}
