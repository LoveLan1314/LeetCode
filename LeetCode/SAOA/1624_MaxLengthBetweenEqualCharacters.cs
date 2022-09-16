using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class MaxLengthBetweenEqualCharactersSolution
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            var pairs = new Dictionary<char, List<int>>();
            for (int i = 0; i < s.Length; i++)
            {
                if (pairs.TryGetValue(s[i], out var list))
                {
                    list.Add(i);
                }
                else
                {
                    pairs.Add(s[i], new List<int>() { i });
                }
            }
            var max = -1;
            foreach (var item in pairs)
            {
                if (item.Value.Count >= 2)
                {
                    max = Math.Max(max, item.Value[^1] - item.Value[0] - 1);
                }
            }
            return max;
        }
    }
}
