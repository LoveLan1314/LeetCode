using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Explore.IntermediateAlgorithm.DynamicPlanning
{
    internal class CanJumpSolution
    {
        public bool CanJump(int[] nums)
        {
            List<int> dp = new List<int>() { 0 };
            for (int i = 1; i < nums.Length; i++)
            {
                dp.Add(System.Math.Max(dp[i - 1], nums[i - 1]) - 1);
                if (dp[i] < 0)
                {
                    return false;
                }
            }
            return dp.Last() >= 0;
        }
    }
}
