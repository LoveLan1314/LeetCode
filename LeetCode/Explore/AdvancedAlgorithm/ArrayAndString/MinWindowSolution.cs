using System.Collections.Generic;

namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    class MinWindowSolution
    {
        public string MinWindow(string s, string t)
        {
            string result = "";
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            int left = 0;
            int cnt = 0;
            int minLen = int.MaxValue;
            foreach (var item in t)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item]++;
                }
                else
                {
                    pairs.Add(item, 1);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (pairs.ContainsKey(s[i]) && --pairs[s[i]] >= 0)
                {
                    cnt++;
                }
                while (cnt == t.Length)
                {
                    if (minLen > i - left + 1)
                    {
                        minLen = i - left + 1;
                        result = s.Substring(left, minLen);
                    }
                    if (pairs.ContainsKey(s[left]) && ++pairs[s[left]] > 0)
                    {
                        cnt--;
                    }
                    left++;
                }
            }
            return result;
        }
    }
}
