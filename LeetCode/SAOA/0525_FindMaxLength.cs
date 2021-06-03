﻿using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindMaxLengthSolution
    {
        public int FindMaxLength(int[] nums)
        {
            int maxLength = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int counter = 0;
            dictionary.Add(counter, -1);
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                int num = nums[i];
                if (num == 1)
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
                if (dictionary.ContainsKey(counter))
                {
                    int prevIndex = dictionary[counter];
                    maxLength = Math.Max(maxLength, i - prevIndex);
                }
                else
                {
                    dictionary.Add(counter, i);
                }
            }
            return maxLength;
        }
    }
}
