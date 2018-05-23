using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.String
{
    class ReverseStringSolution
    {
        public string ReverseString(string s)
        {
            var list = s.ToCharArray();
            for (int i = 0; i < list.Length / 2; i++)
            {
                char swap = list[i];
                list[i] = list[list.Length - 1 - i];
                list[list.Length - 1 - i] = swap;
            }
            return new string(list);
        }

        public string ReverseString1(string s)
        {
            char[] chars = new char[s.Length];
            int start = 0;
            int end = s.Length - 1;
            while (start <= end)
            {
                chars[start] = s[end];
                chars[end] = s[start];
                start++;
                end--;
            }
            return new string(chars);
        }
    }
}
