using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MaximumSumSolution
    {
        public int MaximumSum(int[] nums)
        {
            var pairs = new Dictionary<int, List<int>>();
            foreach (var item in nums)
            {
                var sum = 0;
                var num = item;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (pairs.TryGetValue(sum, out var list))
                {
                    list.Add(item);
                }
                else
                {
                    pairs.Add(sum, new List<int>() { item });
                }
            }
            var max = -1;
            foreach (var item in pairs)
            {
                if (item.Value.Count > 1)
                {
                    var list = item.Value.OrderByDescending(i => i).ToList();
                    max = Math.Max(max, list[0] + list[1]);
                }
            }
            return max;
        }
    }
}
