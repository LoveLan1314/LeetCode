using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.String
{
    class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                if (prefix.Length == 0 || strs[i].Length == 0)
                {
                    return "";
                }

                int len = System.Math.Min(prefix.Length, strs[i].Length);
                int j = 0;
                for (; j < len; j++)
                {
                    if (prefix[j] != strs[i][j])
                    {
                        break;
                    }
                }
                prefix = prefix.Substring(0, j);
            }
            return prefix;
        }
    }
}
