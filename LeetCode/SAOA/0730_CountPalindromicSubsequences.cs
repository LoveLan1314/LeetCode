﻿namespace LeetCode.SAOA
{
    internal sealed class CountPalindromicSubsequencesSolution
    {
        public int CountPalindromicSubsequences(string s)
        {
            const int MOD = 1000000007;
            int n = s.Length;
            int[,,] dp = new int[4, n, n];
            for (int i = 0; i < n; i++)
            {
                dp[s[i] - 'a', i, i] = 1;
            }

            for (int len = 2; len <= n; len++)
            {
                for (int i = 0; i + len <= n; i++)
                {
                    int j = i + len - 1;
                    for (char c = 'a'; c <= 'd'; c++)
                    {
                        int k = c - 'a';
                        if (s[i] == c && s[j] == c)
                        {
                            dp[k, i, j] = (2 + (dp[0, i + 1, j - 1] + dp[1, i + 1, j - 1]) % MOD + (dp[2, i + 1, j - 1] + dp[3, i + 1, j - 1]) % MOD) % MOD;
                        }
                        else if (s[i] == c)
                        {
                            dp[k, i, j] = dp[k, i, j - 1];
                        }
                        else if (s[j] == c)
                        {
                            dp[k, i, j] = dp[k, i + 1, j];
                        }
                        else
                        {
                            dp[k, i, j] = dp[k, i + 1, j - 1];
                        }
                    }
                }
            }

            int res = 0;
            for (int i = 0; i < 4; i++)
            {
                res = (res + dp[i, 0, n - 1]) % MOD;
            }
            return res;
        }
    }
}
