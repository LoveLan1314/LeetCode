using System;

namespace LeetCode.SAOA
{
    internal sealed class MinCostSolution
    {
        public int MinCost(int[][] costs)
        {
            int n = costs.Length;
            int[] dp = new int[3];
            for (int j = 0; j < 3; j++)
            {
                dp[j] = costs[0][j];
            }
            for (int i = 1; i < n; i++)
            {
                int[] dpNew = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    dpNew[j] = Math.Min(dp[(j + 1) % 3], dp[(j + 2) % 3]) + costs[i][j];
                }
                dp = dpNew;
            }
            return Math.Min(Math.Min(dp[0], dp[1]), dp[2]);
        }
    }
}
