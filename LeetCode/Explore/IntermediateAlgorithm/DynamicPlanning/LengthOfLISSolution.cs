using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.DynamicPlanning
{
    class LengthOfLISSolution
    {
        public int LengthOfLIS(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }
            int[] dp = new int[nums.Length];
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if(nums[j] < nums[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
                if(dp[i] > max)
                {
                    max = dp[i];
                }
            }
            return max;
        }
    }
}
