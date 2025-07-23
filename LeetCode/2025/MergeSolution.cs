using System;
using System.Collections.Generic;

namespace LeetCode._2025
{
    internal sealed class MergeSolution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return [];
            }
            Array.Sort(intervals, (a, b) => a[0] - b[0]);
            List<int[]> merged = [];
            for (int i = 0; i < intervals.Length; i++)
            {
                int L = intervals[i][0], R = intervals[i][1];
                if (merged.Count == 0 || merged[^1][1] < L)
                {
                    merged.Add([L, R]);
                }
                else
                {
                    merged[^1][1] = Math.Max(merged[^1][1], R);
                }
            }
            return [.. merged];
        }
    }
}
