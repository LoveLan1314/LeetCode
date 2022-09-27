using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CheckPermutationSolution
    {
        public bool CheckPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            var dict1 = new Dictionary<char, int>();
            var dict2 = new Dictionary<char, int>();
            foreach (var item in s1)
            {
                if (dict1.TryGetValue(item, out var value))
                {
                    dict1[item] = value + 1;
                }
                else
                {
                    dict1.Add(item, 1);
                }
            }
            foreach (var item in s2)
            {
                if (dict2.TryGetValue(item, out var value))
                {
                    dict2[item] = value + 1;
                }
                else
                {
                    dict2.Add(item, 1);
                }
            }
            if (dict1.Count != dict2.Count)
            {
                return false;
            }
            foreach (var item in dict1)
            {
                if (!dict2.TryGetValue(item.Key, out var value) || item.Value != value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
