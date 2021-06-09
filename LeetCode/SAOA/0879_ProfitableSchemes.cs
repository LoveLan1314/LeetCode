using System;

namespace LeetCode.SAOA
{
    internal sealed class ProfitableSchemesSolution
    {
        public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
        {
            int len = group.Length;
            int mod = (int)1e9 + 7;
            int[,,] dp = new int[len + 1, n + 1, minProfit + 1];
            dp[0, 0, 0] = 1;
            for (int i = 1; i <= len; i++)
            {
                int members = group[i - 1];
                int earn = profit[i - 1];
                for (int j = 0; j <= n; j++)
                {
                    for (int k = 0; k <= minProfit; k++)
                    {
                        if (j < members)
                        {
                            dp[i, j, k] = dp[i - 1, j, k];
                        }
                        else
                        {
                            dp[i, j, k] = (dp[i - 1, j, k] + dp[i - 1, j - members, Math.Max(0, k - earn)]) % mod;
                        }
                    }
                }
            }

            int sum = 0;
            for (int j = 0; j <= n; j++)
            {
                sum = (sum + dp[len, j, minProfit]) % mod;
            }
            return sum;
        }
    }
}
