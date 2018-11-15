namespace LeetCode.Explore.IntermediateAlgorithm.DynamicPlanning
{
    internal class CoinChangeSolution
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0)
            {
                return 0;
            }

            int len = coins.Length;
            int[] dp = new int[amount + 1];
            for (int i = 1; i < amount + 1; i++)
            {
                dp[i] = i + 1;
            }
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                int h = amount + 1;
                for (int j = 0; j < len; j++)
                {
                    if(coins[j] <= i && dp[i-coins[j]] != -1)
                    {
                        if(dp[i - coins[j]] <= h)
                        {
                            h = dp[i - coins[j]];
                        }
                    }
                }
                if(h < i + 1)
                {
                    dp[i] = h + 1;
                }
                else
                {
                    dp[i] = -1;
                }
            }
            return dp[amount];
        }
    }
}
