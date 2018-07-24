using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Math
{
    class RomanToIntSolution
    {
        public int RomanToInt(string s)
        {
            int res = 0;
            Dictionary<char, int> pairs = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            for (int i = 0; i < s.Length; i++)
            {
                int val = pairs[s[i]];
                if (i == s.Length - 1 || pairs[s[i + 1]] <= val)
                {
                    res += val;
                }
                else
                {
                    res -= val;
                }
            }
            return res;
        }
        public int RomanToInt2(string s)
        {
            int res = 0;
            Dictionary<char, int> pairs = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 || pairs[s[i]] <= pairs[s[i - 1]])
                {
                    res += pairs[s[i]];
                }
                else
                {
                    res += pairs[s[i]] - 2 * pairs[s[i - 1]];
                }
            }
            return res;
        }
    }
}
