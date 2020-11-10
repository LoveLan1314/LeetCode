using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AlgorithmIntervie.Array
{
    internal sealed class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            int result = nums[0];
            int cnt = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == result)
                {
                    cnt++;
                }
                else
                {
                    cnt--;
                    if (cnt == 0)
                    {
                        result = nums[i];
                        cnt = 1;
                    }
                }
            }
            return result;
        }
    }
}
