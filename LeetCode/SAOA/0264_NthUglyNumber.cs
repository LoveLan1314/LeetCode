using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class NthUglyNumberSolution
    {
        public int NthUglyNumber(int n)
        {
            int index = 0;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (IsUgly(i))
                {
                    index++;
                    if (n == index)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private bool IsUgly(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            int[] factors = new int[] { 2, 3, 5 };
            for (int i = 0; i < factors.Length; i++)
            {
                while (n % factors[i] == 0)
                {
                    n /= factors[i];
                }
            }
            return n == 1;
        }

        //动态规划解法
        public int NthUglyNumber2(int n)
        {
            int[] dp = new int[n + 1];
            dp[1] = 1;
            int p2 = 1, p3 = 1, p5 = 1;
            for (int i = 2; i <= n; i++)
            {
                int num2 = dp[p2] * 2, num3 = dp[p3] * 3, num5 = dp[p5] * 5;
                dp[i] = Math.Min(Math.Min(num2, num3), num5);
                if (dp[i] == num2)
                {
                    p2++;
                }
                if (dp[i] == num3)
                {
                    p3++;
                }
                if (dp[i] == num5)
                {
                    p5++;
                }
            }
            return dp[n];
        }
    }
}
