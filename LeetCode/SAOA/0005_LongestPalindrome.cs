namespace LeetCode.SAOA
{
    internal sealed class LongestPalindromeSolution
    {
        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            bool[,] dp = new bool[n, n];
            string ans = "";
            for (int l = 0; l < n; ++l)
            {
                for (int i = 0; i + l < n; ++i)
                {
                    int j = i + l;
                    if (l == 0)
                    {
                        dp[i, j] = true;
                    }
                    else if (l == 1)
                    {
                        dp[i, j] = s[i] == s[j];
                    }
                    else
                    {
                        dp[i, j] = s[i] == s[j] && dp[i + 1, j - 1];
                    }
                    if (dp[i, j] && l + 1 > ans.Length)
                    {
                        ans = s.Substring(i, l + 1);
                    }
                }
            }
            return ans;
        }
    }
}
