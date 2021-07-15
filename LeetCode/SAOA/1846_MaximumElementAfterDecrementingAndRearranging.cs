using System;

namespace LeetCode.SAOA
{
    internal sealed class MaximumElementAfterDecrementingAndRearrangingSolution
    {
        public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
        {
            Array.Sort(arr);
            int prev = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                int value = arr[i];
                if (value - prev > 1)
                {
                    value = prev + 1;
                }
                prev = value;
            }
            return prev;
        }
    }
}
