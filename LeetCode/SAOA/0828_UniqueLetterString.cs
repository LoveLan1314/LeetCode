﻿using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class UniqueLetterStringSolution
    {
        public int UniqueLetterString(string s)
        {
            var index = new Dictionary<char, IList<int>>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!index.ContainsKey(s[i]))
                {
                    index.Add(s[i], new List<int>());
                    index[s[i]].Add(-1);
                }
                index[s[i]].Add(i);
            }
            var res = 0;
            foreach (KeyValuePair<char, IList<int>> pair in index)
            {
                var arr = pair.Value;
                arr.Add(s.Length);
                for (int i = 1; i < arr.Count - 1; i++)
                {
                    res += (arr[i] - arr[i - 1]) * (arr[i + 1] - arr[i]);
                }
            }
            return res;
        }
    }
}
