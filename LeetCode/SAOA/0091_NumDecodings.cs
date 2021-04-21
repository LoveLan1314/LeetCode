namespace LeetCode.SAOA
{
    internal sealed class NumDecodingsSolution
    {
        public int NumDecodings(string s)
        {
            int n = s.Length;
            int[] f = new int[n + 1];
            f[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                if (s[i - 1] != '0')
                {
                    f[i] += f[i - 1];
                }
                if (i > 1 && s[i - 2] != '0' && ((s[i - 2] - '0') * 10 + (s[i - 1] - '0')) <= 26)
                {
                    f[i] += f[i - 2];
                }
            }
            return f[n];
        }

        public int NumDecodings2(string s)
        {
            int n = s.Length;
            // a = f[i-2], b = f[i-1], c=f[i]
            int a = 0, b = 1, c = 0;
            for (int i = 1; i <= n; i++)
            {
                c = 0;
                if (s[i - 1] != '0')
                {
                    c += b;
                }
                if (i > 1 && s[i - 2] != '0' && ((s[i - 2] - '0') * 10 + (s[i - 1] - '0')) <= 26)
                {
                    c += a;
                }
                a = b;
                b = c;
            }
            return c;
        }
    }
}
