using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.String
{
    class StrStrSolution
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }
            //当hacystack循环到少于needle长度时就可以停止循环，否则会超时
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                for (int j = 0, k = i; j < needle.Length && k < haystack.Length; j++, k++)
                {
                    if (haystack[k] != needle[j])
                    {
                        break;
                    }
                    if (j == needle.Length - 1)
                    {
                        return k - (needle.Length - 1);
                    }
                }
            }
            return -1;
        }
    }
}
