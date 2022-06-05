using System;

namespace LeetCode.SAOA
{
    internal sealed class RandPointSolution
    {
        private readonly Random random;
        private readonly double xc;
        private readonly double yc;
        private readonly double r;

        public RandPointSolution(double radius, double x_center, double y_center)
        {
            random = new Random();
            xc = x_center;
            yc = y_center;
            r = radius;
        }

        public double[] RandPoint()
        {
            while (true)
            {
                double x = random.NextDouble() * (2 * r) - r;
                double y = random.NextDouble() * (2 * r) - r;
                if (x * x + y * y <= r * r)
                {
                    return new double[] { xc + x, yc + y };
                }
            }
        }
    }
}
