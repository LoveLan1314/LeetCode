﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class CustomSortStringSolution
    {
        public string CustomSortString(string order, string s)
        {
            int[] val = new int[26];
            for (int i = 0; i < order.Length; ++i)
            {
                val[order[i] - 'a'] = i + 1;
            }
            char[] arr = s.ToCharArray();
            Array.Sort(arr, (c0, c1) => val[c0 - 'a'] - val[c1 - 'a']);
            return new string(arr);
        }
    }
}
