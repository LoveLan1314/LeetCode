namespace LeetCode.Explore.IntermediateAlgorithm.Math
{
    internal class DivideSolution
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }
            long a = (long)System.Math.Abs((double)dividend);
            long b = (long)System.Math.Abs((double)divisor);
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
            return ((dividend ^ divisor) >> 31) < 0 ? -ret : ret;
        }
    }
}
