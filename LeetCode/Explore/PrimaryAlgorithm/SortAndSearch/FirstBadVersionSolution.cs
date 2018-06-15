using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.SortAndSearch
{
    class FirstBadVersionSolution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int min = 1;
            int max = n;
            int mid = 0;
            while (min <= max)
            {
                mid = min + (max - min) / 2;
                if (IsBadVersion(mid))
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return min;
        }
    }
}
