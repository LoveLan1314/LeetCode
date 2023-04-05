using System;

namespace LeetCode.SAOA
{
    internal sealed class _2427_CommonFactorsSolution
    {
        public int CommonFactors(int a, int b)
        {
            int result = 0;
            int min = Math.Min(a, b);
            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
