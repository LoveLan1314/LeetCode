﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class NumWaysSolution
    {
        public int NumWays(int steps, int arrLen)
        {
            const int MODULO = 1000000007;
            int maxColumn = Math.Min(arrLen - 1, steps);
            int[,] dp = new int[steps + 1, maxColumn + 1];
            dp[0, 0] = 1;
            for (int i = 1; i <= steps; i++)
            {
                for (int j = 0; j <= maxColumn; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                    if (j - 1 >= 0)
                    {
                        dp[i, j] = (dp[i, j] + dp[i - 1, j - 1]) % MODULO;
                    }
                    if (j + 1 <= maxColumn)
                    {
                        dp[i, j] = (dp[i, j] + dp[i - 1, j + 1]) % MODULO;
                    }
                }
            }
            return dp[steps, 0];
        }

        public int NumWays2(int steps, int arrLen)
        {
            const int MODULO = 1000000007;
            int maxColumn = Math.Min(arrLen - 1, steps);
            int[] dp = new int[maxColumn + 1];
            dp[0] = 1;
            for (int i = 1; i <= steps; i++)
            {
                int[] dpNext = new int[maxColumn + 1];
                for (int j = 0; j <= maxColumn; j++)
                {
                    dpNext[j] = dp[j];
                    if (j - 1 >= 0)
                    {
                        dpNext[j] = (dpNext[j] + dp[j - 1]) % MODULO;
                    }
                    if (j + 1 <= maxColumn)
                    {
                        dpNext[j] = (dpNext[j] + dp[j + 1]) % MODULO;
                    }
                }
                dp = dpNext;
            }
            return dp[0];
        }
    }
}
