using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.String
{
    class IsPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                if (!IsCharOrNum(s[start]))
                {
                    start++;
                    continue;
                }
                if (!IsCharOrNum(s[end]))
                {
                    end--;
                    continue;
                }
                if (s[start] == s[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsCharOrNum(char c) => (c >= '0' && c <= '9') || (c >= 'a' && c <= 'z');
    }
}
