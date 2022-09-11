using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MostFrequentEvenSolution
    {
        public int MostFrequentEven(int[] nums)
        {
            var pairs = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    if (pairs.TryGetValue(item, out var value))
                    {
                        pairs[item] = value + 1;
                    }
                    else
                    {
                        pairs.Add(item, 1);
                    }
                }
            }
            if (pairs.Count > 0)
            {
                return pairs.OrderByDescending(i => i.Value).ThenBy(i => i.Key).First().Key;
            }
            else
            {
                return -1;
            }
        }
    }
}
