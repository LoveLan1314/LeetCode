﻿using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class TotalFruitSolution
    {
        public int TotalFruit(int[] fruits)
        {
            int n = fruits.Length;
            IDictionary<int, int> cnt = new Dictionary<int, int>();

            int left = 0, ans = 0;
            for (int right = 0; right < n; ++right)
            {
                cnt.TryAdd(fruits[right], 0);
                ++cnt[fruits[right]];
                while (cnt.Count > 2)
                {
                    --cnt[fruits[left]];
                    if (cnt[fruits[left]] == 0)
                    {
                        cnt.Remove(fruits[left]);
                    }
                    ++left;
                }
                ans = Math.Max(ans, right - left + 1);
            }
            return ans;
        }
    }
}
