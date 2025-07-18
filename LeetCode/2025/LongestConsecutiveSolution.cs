using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2025
{
    internal sealed class LongestConsecutiveSolution
    {
        public int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>(nums.Distinct());
            int longestStreak = 0;
            foreach (var item in set)
            {
                if (!set.Contains(item - 1))
                {
                    int currentNum = item;
                    int currentStreak = 1;
                    while (set.Contains(currentNum + 1))
                    {
                        currentNum += 1;
                        currentStreak += 1;
                    }
                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }
            return longestStreak;
        }
    }
}
