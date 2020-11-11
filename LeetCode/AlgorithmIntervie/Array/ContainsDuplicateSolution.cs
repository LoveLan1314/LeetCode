using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AlgorithmIntervie.Array
{
    internal sealed class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> vs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (vs.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    vs.Add(nums[i]);
                }
            }
            return false;
        }
    }
}
