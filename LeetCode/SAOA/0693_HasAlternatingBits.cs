﻿namespace LeetCode.SAOA
{
    internal sealed class HasAlternatingBitsSolution
    {
        public bool HasAlternatingBits(int n)
        {
            int prev = 2;
            while (n != 0)
            {
                int cur = n % 2;
                if (cur == prev)
                {
                    return false;
                }
                prev = cur;
                n /= 2;
            }
            return true;
        }
    }
}
