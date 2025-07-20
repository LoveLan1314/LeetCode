using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2025
{
    internal sealed class FindAnagramsSolution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            int sLen = s.Length;
            int pLen = p.Length;

            if (sLen < pLen)
            {
                return new List<int>();
            }

            IList<int> ans = new List<int>();
            int[] sCount = new int[26];
            int[] pCount = new int[26];
            //先将p串和对应的s串开头识别到count中
            for (int i = 0; i < pLen; i++)
            {
                sCount[s[i] - 'a']++;
                pCount[p[i] - 'a']++;
            }

            if (Enumerable.SequenceEqual(sCount, pCount))
            {
                ans.Add(0);
            }

            for (int i = 0; i < sLen - pLen; i++)
            {
                sCount[s[i] - 'a']--;
                sCount[s[i + pLen] - 'a']++;
                if (Enumerable.SequenceEqual(sCount, pCount))
                {
                    ans.Add(i + 1);
                }
            }
            return ans;
        }
    }
}