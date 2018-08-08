using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.ArrayAndString
{
    class IncreasingTripletSolution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int m1 = int.MaxValue;
            int m2 = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (m1 >= nums[i])
                {
                    m1 = nums[i];
                }
                else if (m2 >= nums[i])
                {
                    m2 = nums[i];
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
