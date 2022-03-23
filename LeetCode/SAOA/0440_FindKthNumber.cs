using System;

namespace LeetCode.SAOA
{
    internal sealed class FindKthNumberSolution
    {
        public int FindKthNumber(int n, int k)
        {
            int curr = 1;
            k--;
            while (k > 0)
            {
                int steps = GetSteps(curr, n);
                if (steps <= k)
                {
                    k -= steps;
                    curr++;
                }
                else
                {
                    curr *= 10;
                    k--;
                }
            }
            return curr;
        }

        private int GetSteps(int curr, int n)
        {
            long steps = 0;
            long first = curr;
            long last = curr;
            while (first <= n)
            {
                steps += Math.Min(last, n) - first + 1;
                first *= 10;
                last = last * 10 + 9;
            }
            return (int)steps;
        }
    }
}
