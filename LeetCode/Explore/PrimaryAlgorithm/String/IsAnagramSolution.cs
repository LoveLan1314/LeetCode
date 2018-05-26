using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.String
{
    class IsAnagramSolution
    {
        public bool IsAnagram(string s,string t)
        {
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (pairs.ContainsKey(s[i]))
                {
                    pairs[s[i]] = ++pairs[s[i]];
                }
                else
                {
                    pairs.Add(s[i], 1);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (pairs.ContainsKey(t[i]))
                {
                    pairs[t[i]] = --pairs[t[i]];
                }
                else
                {
                    return false;
                }
            }
            foreach (var item in pairs)
            {
                if(item.Value != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsAnagram2(string s,string t)
        {
            if(s.Length!= t.Length)
            {
                return false;
            }
            int[] sList = new int[26];
            int[] tList = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                sList[s[i] - 97]++;
                tList[t[i] - 97]++;
            }
            for (int i = 0; i < 26; i++)
            {
                if (sList[i] != tList[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
