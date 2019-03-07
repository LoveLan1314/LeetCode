using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.ArrayAndString
{
    class LongestPalindromeSolution
    {
        public string LongestPalindrome(string s)
        {
            string t = "$#";
            for (int i = 0; i < s.Length; i++)
            {
                t += s[i];
                t += "#";
            }
            int[] p = new int[t.Length];
            int id = 0;
            int mx = 0;
            int resId = 0;
            int resMx = 0;
            for (int i = 1; i < t.Length; i++)
            {
                p[i] = mx > i ? System.Math.Min(p[2 * id - i], mx - i) : 1;
                while (i + p[i] < t.Length && i - p[i] > 0 && t[i + p[i]] == t[i - p[i]])
                {
                    ++p[i];
                }
                if (mx < i + p[i])
                {
                    mx = i + p[i];
                    id = i;
                }
                if (resMx < p[i])
                {
                    resMx = p[i];
                    resId = i;
                }
            }
            return s.Substring((resId - resMx) / 2, resMx - 1);
        }
    }
}
