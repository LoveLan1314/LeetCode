using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MinSubsequenceSolution
    {
        public IList<int> MinSubsequence(int[] nums)
        {
            Array.Sort(nums);
            var half = nums.Sum() / 2;
            var sum = 0;
            var result = new List<int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result.Add(nums[i]);
                sum += nums[i];
                if (sum > half)
                {
                    break;
                }
            }
            return result;
        }
    }
}
