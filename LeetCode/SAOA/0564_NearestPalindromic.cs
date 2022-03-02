using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class NearestPalindromicSolution
    {
        public string NearestPalindromic(string n)
        {
            long selfNumber = long.Parse(n), ans = -1;
            var candidates = GetCandidates(n);
            foreach (long candidate in candidates)
            {
                if (candidate != selfNumber)
                {
                    if (ans == -1 ||
                        Math.Abs(candidate - selfNumber) < Math.Abs(ans - selfNumber) ||
                        (Math.Abs(candidate - selfNumber) == Math.Abs(ans - selfNumber) && candidate < ans))
                    {
                        ans = candidate;
                    }
                }
            }
            return ans.ToString();
        }

        private List<long> GetCandidates(string n)
        {
            int len = n.Length;
            var candidates = new List<long>
            {
                (long)Math.Pow(10, len - 1) - 1,
                (long)Math.Pow(10, len) + 1
            };
            long selfPrefix = long.Parse(n.Substring(0, (len + 1) / 2));
            for (long i = selfPrefix - 1; i <= selfPrefix + 1; i++)
            {
                var sb = new StringBuilder();
                var prefix = i.ToString();
                sb.Append(prefix);
                var suffix = new StringBuilder();
                for (int j = prefix.Length - 1 - (len & 1); j >= 0; j--)
                {
                    suffix.Append(prefix[j]);
                }
                sb.Append(suffix);
                candidates.Add(long.Parse(sb.ToString()));
            }
            return candidates;
        }
    }
}
