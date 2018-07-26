using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.DynamicPlanning
{
    class RobSolution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int[] sum = new int[nums.Length];
            sum[0] = nums[0];
            sum[1] = System.Math.Max(nums[1], nums[0]);
            int max = sum[1];
            for (int i = 2; i < nums.Length; i++)
            {
                sum[i] = System.Math.Max(sum[i - 1], sum[i - 2] + nums[i]);
                if (max < sum[i])
                {
                    max = sum[i];
                }
            }
            return max;
        }
    }
}
