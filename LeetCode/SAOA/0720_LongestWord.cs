using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal class LongestWordSolution
    {
        public string LongestWord(string[] words)
        {
            Array.Sort(words, (a, b) =>
            {
                if (a.Length != b.Length)
                {
                    return a.Length - b.Length;
                }
                else
                {
                    //倒序排列，保证相同长度，之后遇到的是字典序最小的
                    return b.CompareTo(a);
                }
            });

            string longest = "";
            var candidates = new HashSet<string>();
            candidates.Add("");
            int n = words.Length;
            for (int i = 0; i < n; i++)
            {
                string word = words[i];
                if (candidates.Contains(word.Substring(0, word.Length - 1)))
                {
                    candidates.Add(word);
                    longest = word;
                }
            }
            return longest;
        }
    }
}
