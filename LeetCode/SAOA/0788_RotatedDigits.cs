﻿namespace LeetCode.SAOA
{
    internal sealed class RotatedDigitsSolution
    {
        static readonly int[] check = { 0, 0, 1, -1, -1, 1, 1, -1, 0, 1 };
        public int RotatedDigits(int n)
        {
            int ans = 0;
            for (int i = 1; i <= n; ++i)
            {
                string num = i.ToString();
                bool valid = true, diff = false;
                foreach (char ch in num)
                {
                    if (check[ch - '0'] == -1)
                    {
                        valid = false;
                    }
                    else if (check[ch - '0'] == 1)
                    {
                        diff = true;
                    }
                }
                if (valid && diff)
                {
                    ++ans;
                }
            }
            return ans;
        }
    }
}
