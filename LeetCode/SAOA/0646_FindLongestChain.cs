﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class FindLongestChainSolution
    {
        public int FindLongestChain(int[][] pairs)
        {
            int n = pairs.Length;
            Array.Sort(pairs, (a, b) => a[0] - b[0]);
            int[] dp = new int[n];
            Array.Fill(dp, 1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (pairs[i][0] > pairs[j][1])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }
            return dp[n - 1];
        }
    }
}
