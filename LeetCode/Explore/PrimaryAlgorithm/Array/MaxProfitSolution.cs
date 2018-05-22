using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm
{
    class MaxProfitSolution
    {
        public int MaxProfit(int[] prices)
        {
            int maxPro = 0;
            int temp = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                temp = prices[i] - prices[i - 1];
                if(temp > 0)
                {
                    maxPro += temp;
                }
            }
            return maxPro;
        }
    }
}
