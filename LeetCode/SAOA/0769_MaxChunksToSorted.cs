using System;

namespace LeetCode.SAOA
{
    internal sealed class MaxChunksToSortedSolution1
    {
        public int MaxChunksToSorted(int[] arr)
        {
            int m = 0, res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                m = Math.Max(m, arr[i]);
                if (m == i)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
