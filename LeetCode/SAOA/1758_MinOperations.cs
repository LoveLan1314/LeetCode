﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class MinOperationsSolution2
    {
        public int MinOperations(string s)
        {
            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c != (char)('0' + i % 2))
                {
                    cnt++;
                }
            }
            return Math.Min(cnt, s.Length - cnt);
        }
    }
}
