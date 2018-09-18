using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.SortAndSearch
{
    class FindPeakElementSolution
    {
        public int FindPeakElement(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }
            int left = 0;
            int right = nums.Length - 1;
            while(left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] < nums[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}
