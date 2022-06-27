﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class FindLUSlengthSolution1
    {
        public int FindLUSlength(string[] strs)
        {
            int n = strs.Length;
            int ans = -1;
            for (int i = 0; i < n; ++i)
            {
                bool check = true;
                for (int j = 0; j < n; ++j)
                {
                    if (i != j && IsSubseq(strs[i], strs[j]))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    ans = Math.Max(ans, strs[i].Length);
                }
            }
            return ans;
        }

        private bool IsSubseq(string s, string t)
        {
            int ptS = 0, ptT = 0;
            while (ptS < s.Length && ptT < t.Length)
            {
                if (s[ptS] == t[ptT])
                {
                    ++ptS;
                }
                ++ptT;
            }
            return ptS == s.Length;
        }
    }
}
