using System;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class FindSubstringInWraproundStringSolution
    {
        public int FindSubstringInWraproundString(string p)
        {
            int[] dp = new int[26];
            int k = 0;
            for (int i = 0; i < p.Length; ++i)
            {
                if (i > 0 && (p[i] - p[i - 1] + 26) % 26 == 1)
                { // 字符之差为 1 或 -25
                    ++k;
                }
                else
                {
                    k = 1;
                }
                dp[p[i] - 'a'] = Math.Max(dp[p[i] - 'a'], k);
            }
            return dp.Sum();
        }
    }
}
