﻿namespace LeetCode.SAOA
{
    internal sealed class ExpressiveWordsSolution
    {
        public int ExpressiveWords(string s, string[] words)
        {
            int ans = 0;
            foreach (string word in words)
            {
                if (Expand(s, word))
                {
                    ++ans;
                }
            }
            return ans;
        }

        private bool Expand(string s, string t)
        {
            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] != t[j])
                {
                    return false;
                }
                char ch = s[i];
                int cnti = 0;
                while (i < s.Length && s[i] == ch)
                {
                    ++cnti;
                    ++i;
                }
                int cntj = 0;
                while (j < t.Length && t[j] == ch)
                {
                    ++cntj;
                    ++j;
                }
                if (cnti < cntj)
                {
                    return false;
                }
                if (cnti != cntj && cnti < 3)
                {
                    return false;
                }
            }
            return i == s.Length && j == t.Length;
        }
    }
}
