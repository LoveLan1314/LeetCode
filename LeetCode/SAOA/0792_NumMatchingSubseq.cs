﻿using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class NumMatchingSubseqSolution
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            var p = new Queue<int[]>[26];
            for (int i = 0; i < 26; ++i)
            {
                p[i] = new Queue<int[]>();
            }
            for (int i = 0; i < words.Length; ++i)
            {
                p[words[i][0] - 'a'].Enqueue(new int[] { i, 0 });
            }
            int res = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                char c = s[i];
                int len = p[c - 'a'].Count;
                while (len > 0)
                {
                    int[] t = p[c - 'a'].Dequeue();
                    if (t[1] == words[t[0]].Length - 1)
                    {
                        ++res;
                    }
                    else
                    {
                        ++t[1];
                        p[words[t[0]][t[1]] - 'a'].Enqueue(t);
                    }
                    --len;
                }
            }
            return res;
        }
    }
}
