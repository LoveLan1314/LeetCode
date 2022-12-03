using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class _1796_SecondHighestSolution
    {
        public int SecondHighest(string s)
        {
            var set = new HashSet<int>();
            foreach (char item in s)
            {
                if (item >= 48 && item <= 57)
                {
                    int number = item - '0';
                    if (!set.Contains(number))
                    {
                        set.Add(number);
                    }
                }
            }
            if (set.Count > 1)
            {
                return set.OrderByDescending(x => x).ToList()[1];
            }
            else
            {
                return -1;
            }
        }
    }
}
