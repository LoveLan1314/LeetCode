using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindAndReplacePatternSolution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            IList<string> ans = new List<string>();
            foreach (string word in words)
            {
                if (Match(word, pattern) && Match(pattern, word))
                {
                    ans.Add(word);
                }
            }
            return ans;
        }

        private bool Match(string word, string pattern)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            for (int i = 0; i < word.Length; ++i)
            {
                char x = word[i], y = pattern[i];
                if (!dic.ContainsKey(x))
                {
                    dic.Add(x, y);
                }
                else if (dic[x] != y)
                { // word 中的同一字母必须映射到 pattern 中的同一字母上
                    return false;
                }
            }
            return true;
        }

    }
}
