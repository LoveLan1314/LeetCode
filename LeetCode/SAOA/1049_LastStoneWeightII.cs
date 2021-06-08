using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class LastStoneWeightIISolution
    {
        public int LastStoneWeightII(int[] stones)
        {
            int sum = stones.Sum();
            int n = stones.Length;
            int m = sum / 2;
            bool[,] dp = new bool[n + 1, m + 1];
            dp[0, 0] = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    if (j < stones[i])
                    {
                        dp[i + 1, j] = dp[i, j];
                    }
                    else
                    {
                        dp[i + 1, j] = dp[i, j] || dp[i, j - stones[i]];
                    }
                }
            }

            for (int j = m; ; j--)
            {
                if (dp[n, j])
                {
                    return sum - 2 * j;
                }
            }
        }
    }
}
