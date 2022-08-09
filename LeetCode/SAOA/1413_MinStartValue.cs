using System;

namespace LeetCode.SAOA
{
    internal sealed class MinStartValueSolution
    {
        public int MinStartValue(int[] nums)
        {
            var minValue = int.MaxValue;
            var current = 0;
            foreach (var item in nums)
            {
                current += item;
                minValue = Math.Min(minValue, current);
            }
            var result = 1 - minValue;
            if (result > 0)
            {
                return result;
            }
            else
            {
                return 1;
            }
        }
    }
}
