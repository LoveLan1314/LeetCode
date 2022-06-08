namespace LeetCode.SAOA
{
    internal sealed class IsBoomerangSolution
    {
        public bool IsBoomerang(int[][] points)
        {
            var first = points[0];
            var second = points[1];
            var third = points[2];

            if (IsSame(first, second) || IsSame(first, third) || IsSame(second, third))
            {
                return false;
            }
            var slope1 = GetSlope(first, second);
            var slope2 = GetSlope(first, third);
            var slope3 = GetSlope(second, third);
            return slope1 != slope2 && slope1 != slope3 && slope2 != slope3;
        }

        private bool IsSame(int[] left, int[] right)
        {
            return left[0] == right[0] && left[1] == right[1];
        }

        private double GetSlope(int[] left, int[] right)
        {
            return (double)(left[0] - right[0]) / (left[1] - right[1]);
        }

        public bool IsBoomerang1(int[][] points)
        {
            int[] v1 = { points[1][0] - points[0][0], points[1][1] - points[0][1] };
            int[] v2 = { points[2][0] - points[0][0], points[2][1] - points[0][1] };
            return v1[0] * v2[1] - v1[1] * v2[0] != 0;
        }
    }
}
