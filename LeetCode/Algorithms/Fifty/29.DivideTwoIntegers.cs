using System;

namespace ConsoleApplication.Algorithms.Fifty
{
    class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if(dividend == int.MinValue && divisor == -1) return int.MaxValue;
            long a = Math.Abs(dividend);
            long b = Math.Abs(divisor);
            int ret = 0;
            while (a >= b)
            {
                long c = b;
                for (int i = 0; c <= a; i++)
                {
                    a -= c;
                    ret += 1 << i;
                    c = c << 1;
                }
            }
            return ((dividend ^ divisor) >> 31) <0 ? (int)(-ret) : (int)(ret);
        }
    }
}