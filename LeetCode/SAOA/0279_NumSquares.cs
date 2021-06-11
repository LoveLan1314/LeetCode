using System;

namespace LeetCode.SAOA
{
    internal sealed class NumSquaresSolution
    {
        public int NumSquares(int n)
        {
            int[] dp = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                int min = int.MaxValue;
                for (int j = 1; j * j <= i; j++)
                {
                    min = Math.Min(min, dp[i - j * j]);
                }
                dp[i] = min + 1;
            }
            return dp[n];
        }
    }
}
