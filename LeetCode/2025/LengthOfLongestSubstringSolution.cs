using System;
using System.Collections.Generic;

namespace LeetCode._2025
{
    internal sealed class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int left = 0;
            int right = 1;
            int n = s.Length;
            if (n == 0)
            {
                return 0;
            }
            int ans = 1;
            while (right < n)
            {
                var str = s[left..right];
                var index = str.IndexOf(s[right]);
                if (index == -1)
                {
                    //该字符串不在原序列中
                    ans = Math.Max(ans, str.Length + 1);
                }
                else
                {
                    left += index + 1;
                    right = Math.Max(left, right);
                }
                right++;
            }
            return ans;
        }

        public int LengthOfLongestSubstring2(string s)
        {
            var set = new HashSet<char>();
            int n = s.Length;
            int rk = -1;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (i != 0)
                {
                    set.Remove(s[i - 1]);
                }
                while (rk + 1 < n && !set.Contains(s[rk + 1]))
                {
                    set.Add(s[rk + 1]);
                    rk++;
                }
                ans = Math.Max(ans, rk - i + 1);
            }
            return ans;
        }
    }
}