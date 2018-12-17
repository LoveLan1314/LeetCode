namespace LeetCode.Explore.IntermediateAlgorithm.Math
{
    internal class MyPowSolution
    {
        public double MyPow(double x, int n)
        {
            if (n < 0)
            {
                return 1 / Power(x, -n);
            }
            else
            {
                return Power(x, n);
            }
        }

        private double Power(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            double half = Power(x, n / 2);
            if (n % 2 == 0)
            {
                return half * half;
            }
            else
            {
                return x * half * half;
            }
        }
    }
}
