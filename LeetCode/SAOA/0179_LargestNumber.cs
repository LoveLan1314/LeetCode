using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class LargestNumberSolution
    {
        public string LargestNumber(int[] nums)
        {
            Array.Sort(nums, new NumberComparer());
            if (nums[0] == 0)
            {
                return "0";
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                sb.Append(nums[i]);
            }
            return sb.ToString();
        }

        private class NumberComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                var value1 = long.Parse(x.ToString() + y.ToString());
                var value2 = long.Parse(y.ToString() + x.ToString());
                return (int)(value2 - value1);
            }
        }
    }
}
