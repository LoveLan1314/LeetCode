using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DataStructure.ArrayAndString
{
    class DominantIndexSolution
    {
        public int DominantIndex(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            int maxIndex = -1;
            int secondIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (maxIndex == -1 || nums[i] > nums[maxIndex])
                {
                    secondIndex = maxIndex;
                    maxIndex = i;
                }
                else if (secondIndex == -1 || nums[i] > nums[secondIndex])
                {
                    secondIndex = i;
                }
            }
            if (nums[maxIndex] >= nums[secondIndex] * 2)
            {
                return maxIndex;
            }
            else
            {
                return -1;
            }
        }
    }
}
