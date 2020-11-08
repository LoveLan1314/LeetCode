using System.Collections.Generic;

namespace LeetCode.AlgorithmIntervie.String
{
    internal sealed class FirstUniqCharSolution
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (pairs.ContainsKey(s[i]))
                {
                    pairs[s[i]] = -1;
                }
                else
                {
                    pairs.Add(s[i], i);
                }
            }
            foreach (var item in pairs)
            {
                if (item.Value != -1)
                {
                    return item.Value;
                }
            }
            return -1;
        }

        public int FirstUniqChar2(string s)
        {
            if (s == null || s.Length < 1)
            {
                return -1;
            }
            int[] temp = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                temp[s[i] - 'a']++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (temp[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
