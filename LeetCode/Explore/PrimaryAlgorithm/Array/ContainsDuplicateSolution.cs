using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm
{
    class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
                return false;
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsDuplicate1(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
            {
                if (set.Contains(item))
                {
                    return true;
                }
                set.Add(item);
            }
            return false;
        }
    }
}
