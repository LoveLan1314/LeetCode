using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm
{
    class RemoveDuplicatesSolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return 1;
            }
            int result = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[result] != nums[i])
                {
                    result++;
                    nums[result] = nums[i];
                }
            }
            return result + 1;
        }
    }
}
