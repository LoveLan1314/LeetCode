using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int length = s.Length;
            int rk = -1;
            int ans = 0;
            for (int i = 0; i < length; i++)
            {
                if (i != 0)
                {
                    set.Remove(s[i - 1]);
                }
                while (rk + 1 < length && !set.Contains(s[rk + 1]))
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
