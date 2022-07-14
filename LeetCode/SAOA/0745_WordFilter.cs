using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class WordFilter
    {
        private readonly Trie trie;
        private readonly string weightKey;

        public WordFilter(string[] words)
        {
            trie = new Trie();
            weightKey = "##";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                string word = words[i];
                Trie cur = trie;
                string key;
                int m = word.Length;
                for (int j = 0; j < m; j++)
                {
                    Trie tmp = cur;
                    for (int k = j; k < m; k++)
                    {
                        key = new StringBuilder().Append(word[k]).Append('#').ToString();
                        if (!tmp.Children.ContainsKey(key))
                        {
                            tmp.Children.TryAdd(key, new Trie());
                        }
                        tmp = tmp.Children[key];
                        tmp.Weight.TryAdd(weightKey, i);
                    }
                    tmp = cur;
                    for (int k = j; k < m; k++)
                    {
                        key = new StringBuilder().Append('#').Append(word[m - k - 1]).ToString();
                        if (!tmp.Children.ContainsKey(key))
                        {
                            tmp.Children.TryAdd(key, new Trie());
                        }
                        tmp = tmp.Children[key];
                        tmp.Weight.TryAdd(weightKey, i);
                    }
                    key = new StringBuilder().Append(word[j]).Append(word[m - j - 1]).ToString();
                    if (!cur.Children.ContainsKey(key))
                    {
                        cur.Children.TryAdd(key, new Trie());
                    }
                    cur = cur.Children[key];
                    cur.Weight.TryAdd(weightKey, i);
                }
            }
        }

        public int F(string pref, string suff)
        {
            Trie cur = trie;
            int m = Math.Max(pref.Length, suff.Length);
            for (int i = 0; i < m; i++)
            {
                char c1 = i < pref.Length ? pref[i] : '#';
                char c2 = i < suff.Length ? suff[suff.Length - 1 - i] : '#';
                string key = new StringBuilder().Append(c1).Append(c2).ToString();
                if (!cur.Children.ContainsKey(key))
                {
                    return -1;
                }
                cur = cur.Children[key];
            }
            return cur.Weight[weightKey];
        }

        private sealed class Trie
        {
            public Dictionary<string, Trie> Children;
            public Dictionary<string, int> Weight;

            public Trie()
            {
                Children = new Dictionary<string, Trie>();
                Weight = new Dictionary<string, int>();
            }
        }
    }

    internal sealed class WordFilter1
    {
        private readonly Dictionary<string, int> dictionary;

        public WordFilter1(string[] words)
        {
            dictionary = new Dictionary<string, int>();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                string word = words[i];
                int m = word.Length;
                for (int prefixLength = 1; prefixLength <= m; prefixLength++)
                {
                    for (int suffixLength = 1; suffixLength <= m; suffixLength++)
                    {
                        dictionary.TryAdd(word.Substring(0, prefixLength) + "#" + word.Substring(m - suffixLength), i);
                    }
                }
            }
        }

        public int F(string pref, string suff)
        {
            if (dictionary.ContainsKey(pref + "#" + suff))
            {
                return dictionary[pref + "#" + suff];
            }
            return -1;
        }
    }
}
