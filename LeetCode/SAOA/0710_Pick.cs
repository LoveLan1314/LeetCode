using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class PickSolution1
    {
        private readonly Dictionary<int, int> b2w;
        private readonly Random random;
        private readonly int bound;
        public PickSolution1(int n, int[] blacklist)
        {
            b2w = new Dictionary<int, int>();
            random = new Random();
            int m = blacklist.Length;
            bound = n - m;
            ISet<int> black = new HashSet<int>();
            foreach (int b in blacklist)
            {
                if (b >= bound)
                {
                    black.Add(b);
                }
            }

            int w = bound;
            foreach (int b in blacklist)
            {
                if (b < bound)
                {
                    while (black.Contains(w))
                    {
                        ++w;
                    }
                    b2w.Add(b, w);
                    ++w;
                }
            }
        }

        public int Pick()
        {
            int x = random.Next(bound);
            return b2w.ContainsKey(x) ? b2w[x] : x;
        }
    }
}
