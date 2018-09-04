using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.SortAndSearch
{
    class FindKthLargestSolution
    {
        public int FindKthLargest(int[] nums,int k)
        {
            return nums.Cast<int>().OrderByDescending(i => i).Skip(k - 1).First();
        }
    }
}
