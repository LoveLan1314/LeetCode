using System.Collections.Generic;

namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    internal class FindDuplicateSolution
    {
        public int FindDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        return nums[i];
                    }
                }
            }
            return 0;
        }

        public int FindDuplicate1(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
            {
                if (set.Contains(item))
                {
                    return item;
                }
                else
                {
                    set.Add(item);
                }
            }
            return 0;
        }
    }
}
