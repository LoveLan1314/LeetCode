using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class EdgeScoreSolution
    {
        public int EdgeScore(int[] edges)
        {
            var pairs = new Dictionary<int, long>();
            for (int i = 0; i < edges.Length; i++)
            {
                var value = edges[i];
                if (pairs.TryGetValue(value, out var sum))
                {
                    pairs[value] = sum + i;
                }
                else
                {
                    pairs[value] = i;
                }
            }
            return pairs.OrderByDescending(i => i.Value).ThenBy(i => i.Key).First().Key;
        }
    }
}
