﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class MinRefuelStopsSolution
    {
        public int MinRefuelStops(int target, int startFuel, int[][] stations)
        {
            int n = stations.Length;
            long[] dp = new long[n + 1];
            dp[0] = startFuel;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (dp[j] >= stations[i][0])
                    {
                        dp[j + 1] = Math.Max(dp[j + 1], dp[j] + stations[i][1]);
                    }
                }
            }
            for (int i = 0; i <= n; i++)
            {
                if (dp[i] >= target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
