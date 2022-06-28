using System;

namespace LeetCode.SAOA
{
    internal sealed class WiggleSortSolution
    {
        public void WiggleSort(int[] nums)
        {
            var n = nums.Length;
            var copy = new int[n];
            Array.Copy(nums, copy, n);
            Array.Sort(copy);
            int x = (n + 1) / 2;
            for (int i = 0, j = x - 1, k = n - 1; i < n; i += 2, j--, k--)
            {
                nums[i] = copy[j];
                if (i + 1 < n)
                {
                    nums[i + 1] = copy[k];
                }
            }
        }
    }
}
