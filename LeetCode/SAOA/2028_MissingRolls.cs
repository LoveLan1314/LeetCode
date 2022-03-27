﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class MissingRollsSolution
    {
        public int[] MissingRolls(int[] rolls, int mean, int n)
        {
            int m = rolls.Length;
            int sum = mean * (n + m);
            int missingSum = sum;
            foreach (int roll in rolls)
            {
                missingSum -= roll;
            }
            if (missingSum < n || missingSum > 6 * n)
            {
                return Array.Empty<int>();
            }
            int quotient = missingSum / n, remainder = missingSum % n;
            int[] missing = new int[n];
            for (int i = 0; i < n; i++)
            {
                missing[i] = quotient + (i < remainder ? 1 : 0);
            }
            return missing;
        }
    }
}
