﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class StoneGameSolution
    {
        public bool StoneGame(int[] piles)
        {
            int length = piles.Length;
            int[,] dp = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                dp[i, i] = piles[i];
            }
            for (int i = length - 2; i >= 0; i--)
            {
                for (int j = i + 1; j < length; j++)
                {
                    dp[i, j] = Math.Max(piles[i] - dp[i + 1, j], piles[j] - dp[i, j - 1]);
                }
            }
            return dp[0, length - 1] > 0;
        }

        public bool StoneGame1(int[] piles)
        {
            return true;
        }
    }
}
