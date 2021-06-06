﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class FindMaxFormSolution
    {
        public int FindMaxForm(string[] strs, int m, int n)
        {
            int length = strs.Length;
            int[,,] dp = new int[length + 1, m + 1, n + 1];
            for (int i = 1; i <= length; i++)
            {
                var zeroOnes = GetZerosOnes(strs[i - 1]);
                int zeros = zeroOnes[0];
                int ones = zeroOnes[1];
                for (int j = 0; j <= m; j++)
                {
                    for (int k = 0; k <= n; k++)
                    {
                        dp[i, j, k] = dp[i - 1, j, k];
                        if (j >= zeros && k >= ones)
                        {
                            dp[i, j, k] = Math.Max(dp[i, j, k], dp[i - 1, j - zeros, k - ones] + 1);
                        }
                    }
                }
            }
            return dp[length, m, n];
        }

        private int[] GetZerosOnes(string str)
        {
            int[] zerosOnes = new int[2];
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                zerosOnes[str[i] - '0']++;
            }
            return zerosOnes;
        }
    }
}
