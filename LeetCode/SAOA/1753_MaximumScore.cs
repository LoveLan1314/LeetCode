using System;

namespace LeetCode.SAOA
{
    internal sealed class _1753_MaximumScoreSolution
    {
        public int MaximumScore(int a, int b, int c)
        {
            int sum = a + b + c;
            int maxVal = Math.Max(Math.Max(a, b), c);
            return Math.Min(sum - maxVal, sum / 2);
        }
    }
}
