using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.Math
{
    internal class TitleToNumberSolution
    {
        private readonly Dictionary<char, int> _pairs = new Dictionary<char, int>()
        {
            { 'A', 1 },
            { 'B', 2 },
            { 'C', 3 },
            { 'D', 4 },
            { 'E', 5 },
            { 'F', 6 },
            { 'G', 7 },
            { 'H', 8 },
            { 'I', 9 },
            { 'J', 10 },
            { 'K', 11 },
            { 'L', 12 },
            { 'M', 13 },
            { 'N', 14 },
            { 'O', 15 },
            { 'P', 16 },
            { 'Q', 17 },
            { 'R', 18 },
            { 'S', 19 },
            { 'T', 20 },
            { 'U', 21 },
            { 'V', 22 },
            { 'W', 23 },
            { 'X', 24 },
            { 'Y', 25 },
            { 'Z', 26 },
        };

        public int TitleToNumber(string s)
        {
            int result = 0;
            int n = 0;
            for (int i = s.Length; i > 0; i--)
            {
                result += (int)System.Math.Pow(26, n++) * _pairs[s[i - 1]];
            }
            return result;
        }

        public int TItleToNumber2(string s)
        {
            double res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                res += (s[i] - 'A' + 1) * System.Math.Pow(26, s.Length - 1 - i);
            }
            return (int)res;
        }
    }
}
