using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.DynamicPlanning
{
    class MaxProfitSolution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0 || prices.Length == 1)
            {
                return 0;
            }
            int profit = 0;
            int bestBuyPrice = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                int buyPirce = prices[i];
                if(buyPirce < bestBuyPrice)
                {
                    for (int j = i + 1; j < prices.Length; j++)
                    {
                        int currentProfit = prices[j] - buyPirce;
                        if (currentProfit > profit)
                        {
                            profit = currentProfit;
                            bestBuyPrice = buyPirce;
                        }
                    }
                }
            }
            return profit;
        }

        public int MaxProfit2(int[] prices)
        {
            if(prices.Length < 2)
            {
                return 0;
            }

            int max = 0;
            int low = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                max = System.Math.Max(max, prices[i] - low);
                low = System.Math.Min(low, prices[i]);
            }
            return max;
        }
    }
}
