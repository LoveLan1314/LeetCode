﻿namespace LeetCode.SAOA
{
    internal sealed class GenerateTheStringSolution
    {
        public string GenerateTheString(int n)
        {
            if (n % 2 == 1)
            {
                return new string('a', n);
            }
            return new string('a', n - 1) + "b";
        }
    }
}
