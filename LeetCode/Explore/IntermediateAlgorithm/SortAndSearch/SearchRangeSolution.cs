using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.SortAndSearch
{
    class SearchRangeSolution
    {
        public int[] SearchRange(int[] nums,int target)
        {
            int start = -1;
            int end = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    if(start == -1)
                    {
                        start = i;
                    }
                    end = i;
                }
                else if(nums[i] > target)
                {
                    break;
                }
            }
            return new int[] { start, end };
        }
    }
}
