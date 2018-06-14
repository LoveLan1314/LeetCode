using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.SortAndSearch
{
    class MergeSolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            while (m > 0 || n > 0)
            {
                if(m == 0)
                {
                    nums1[m + n - 1] = nums2[n - 1];
                    n--;
                    continue;
                }
                if(n == 0)
                {
                    nums1[m + n - 1] = nums1[m - 1];
                    m--;
                    continue;
                }
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[m + n - 1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[m + n - 1] = nums2[n - 1];
                    n--;
                }
            }
        }
    }
}
