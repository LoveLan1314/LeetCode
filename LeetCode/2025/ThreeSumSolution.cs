using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace LeetCode._2025
{
    internal sealed class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int k = nums.Length - 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    while (j < k && nums[i] + nums[j] + nums[k] > 0)
                    {
                        k--;
                    }
                    if (j == k)
                    {
                        break;
                    }
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        result.Add([nums[i], nums[j], nums[k]]);
                    }
                }
            }
            return result;
        }
    }
}