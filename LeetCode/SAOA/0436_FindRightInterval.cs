﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class FindRightIntervalSolution
    {
        public int[] FindRightInterval(int[][] intervals)
        {
            int n = intervals.Length;
            int[][] startIntervals = new int[n][];
            for (int i = 0; i < n; i++)
            {
                startIntervals[i] = new int[2];
                startIntervals[i][0] = intervals[i][0];
                startIntervals[i][1] = i;
            }
            Array.Sort(startIntervals, (o1, o2) => o1[0] - o2[0]);

            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                int left = 0;
                int right = n - 1;
                int target = -1;
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (startIntervals[mid][0] >= intervals[i][1])
                    {
                        target = startIntervals[mid][1];
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                ans[i] = target;
            }
            return ans;
        }
    }
}
