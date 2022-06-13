using System;

namespace LeetCode.SAOA
{
    internal sealed class HeightCheckerSolution
    {
        public int HeightChecker(int[] heights)
        {
            int n = heights.Length;
            int result = 0;
            int[] copy = new int[n];
            Array.Copy(heights, copy, n);
            Array.Sort(copy);
            for (int i = 0; i < n; i++)
            {
                if (heights[i] != copy[i])
                {
                    result++;
                }
            }
            return result;
        }
    }
}
