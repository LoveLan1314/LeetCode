using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Math
{
    class CountPrimesSolution
    {
        public int CountPrimes(int n)
        {
            int sum = 0;
            if (n == 0 || n == 1)
            {
                return 0;
            }
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    sum++;
                }
            }
            return sum;
        }

        private bool IsPrime(int num)
        {
            if (num == 2 || num == 3)
            {
                return true;
            }
            //不在6的倍数两侧的一定不是质数
            if (num % 6 != 1 && num % 6 != 5)
            {
                return false;
            }
            int tmp = (int)System.Math.Sqrt(num);
            //在6的倍数两侧也可能不是质数
            for (int i = 5; i <= tmp; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }
            //排除所有，剩余的是质数
            return true;
        }
    }
}
