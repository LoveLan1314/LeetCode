using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class LargestPalindromicSolution
    {
        public string LargestPalindromic(string num)
        {
            var pairs = new Dictionary<char, long>();
            foreach (var item in num)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item] = pairs[item] + 1;
                }
                else
                {
                    pairs[item] = 1;
                }
            }
            var sb = new StringBuilder();
            var doublePairs = pairs.Where(i => i.Value >= 2).OrderByDescending(i => i.Key).ToList();
            var singlePairs = pairs.Where(i => i.Value % 2 == 1).OrderByDescending(i => i.Key).ToList();
            if (doublePairs.Count == 1 && doublePairs[0].Key == '0')
            {
                if (singlePairs.Count > 0)
                {
                    sb.Append(singlePairs[0].Key);
                }
                else
                {
                    sb.Append(doublePairs[0].Key);
                }
            }
            else
            {
                foreach (var item in doublePairs)
                {
                    for (long i = 0; i < item.Value / 2; i++)
                    {
                        sb.Append(item.Key);
                    }
                }
                if (singlePairs.Count > 0)
                {
                    sb.Append(singlePairs[0].Key);
                }
                for (int i = doublePairs.Count - 1; i >= 0; i--)
                {
                    var n = doublePairs[i].Value / 2;
                    for (long j = 0; j < n; j++)
                    {
                        sb.Append(doublePairs[i].Key);
                    }
                }
            }
            return sb.ToString();
        }
    }
}
