using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.String
{
    class FirstUniqCharSolution
    {
        public int FirstUniqChar(string s)
        {
            char[] vs = s.ToCharArray();
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            foreach (var item in vs)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item] = ++pairs[item];
                }
                else
                {
                    pairs.Add(item, 1);
                }
            }
            foreach (var item in pairs)
            {
                if(item.Value == 1)
                {
                    return s.IndexOf(item.Key);
                }
            }
            return -1;
        }

        public int FirstUniqChar2(string s)
        {
            int[] store = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                store[s[i]] += 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if(store[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
