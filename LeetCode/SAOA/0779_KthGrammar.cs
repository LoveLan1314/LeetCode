﻿namespace LeetCode.SAOA
{
    internal sealed class KthGrammarSolution
    {
        public int KthGrammar(int n, int k)
        {
            if (n == 1)
            {
                return 0;
            }
            return (k & 1) ^ 1 ^ KthGrammar(n - 1, (k + 1) / 2);
        }
    }
}
