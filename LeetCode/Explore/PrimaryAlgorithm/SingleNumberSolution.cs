using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm
{
    class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var item in nums)
            {
                if (set.Contains(item))
                {
                    set.Remove(item);
                }
                else
                {
                    set.Add(item);
                }
            }
            foreach (var item in set)
            {
                return item;
            }
            return 0;
        }
    }
}
