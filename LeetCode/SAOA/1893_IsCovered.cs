using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class IsCoveredSolution
    {
        public bool IsCovered(int[][] ranges, int left, int right)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = left; i <= right; i++)
            {
                set.Add(i);
            }
            int n = ranges.Length;
            for (int i = 0; i < n; i++)
            {
                var range = ranges[i];
                int start = range[0];
                int end = range[1];
                set.RemoveWhere(i => i >= start && i <= end);
            }
            return set.Count == 0;
        }
    }
}
