using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Others
{
    class MissingNumberSolution
    {
        public int MissingNumber(int[] nums)
        {
            int sum = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
            }
            return (int)(0.5 * n * (n + 1) - sum);
        }
    }
}
