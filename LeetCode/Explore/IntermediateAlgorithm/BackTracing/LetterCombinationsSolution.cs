using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.BackTracing
{
    internal class LetterCombinationsSolution
    {
        private readonly string[] _strings = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if(digits.Length == 0)
            {
                return result;
            }
            BackTracking("", digits, 0, result);
            return result;
        }

        private void BackTracking(string s, string digits, int flag, List<string> list)
        {
            if(flag >= digits.Length)
            {
                list.Add(s);
                return;
            }

            string chars = _strings[digits[flag] - '0'];
            for (int i = 0; i < chars.Length; i++)
            {
                BackTracking(s + chars[i], digits, flag + 1, list);
            }
        }
    }
}
