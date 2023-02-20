using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class _2347_BestHandSolution
    {
        public string BestHand(int[] ranks, char[] suits)
        {
            for (int i = 1; i < suits.Length; i++)
            {
                if (suits[i] != suits[i - 1])
                {
                    break;
                }
                if (i == suits.Length - 1)
                {
                    return "Flush";
                }
            }
            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < ranks.Length; i++)
            {
                if (pairs.TryGetValue(ranks[i], out int _))
                {
                    pairs[ranks[i]]++;
                }
                else
                {
                    pairs.Add(ranks[i], 1);
                }
            }
            int max = pairs.Max(i => i.Value);
            if (max >= 3)
            {
                return "Three of a Kind";
            }
            else if (max == 2)
            {
                return "Pair";
            }
            else
            {
                return "High Card";
            }
        }
    }
}
