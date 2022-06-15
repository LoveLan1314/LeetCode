﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class SmallestDistancePairSolution
    {
        public int SmallestDistancePair(int[] nums, int k)
        {
            Array.Sort(nums);
            int n = nums.Length, left = 0, right = nums[n - 1] - nums[0];
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cnt = 0;
                for (int j = 0; j < n; j++)
                {
                    int i = BinarySearch(nums, j, nums[j] - mid);
                    cnt += j - i;
                }
                if (cnt >= k)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        private int BinarySearch(int[] nums, int end, int target)
        {
            int left = 0, right = end;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}
