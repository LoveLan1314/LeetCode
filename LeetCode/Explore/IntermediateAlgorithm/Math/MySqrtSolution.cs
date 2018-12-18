namespace LeetCode.Explore.IntermediateAlgorithm.Math
{
    internal class MySqrtSolution
    {
        public int MySqrt(int x)
        {
            return (int)System.Math.Sqrt(x);
        }

        public int MySqrt1(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            if (x <= 1)
            {
                return 1;
            }
            int left = 0;
            int right = x;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (x / mid >= mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return right - 1;
        }
    }
}
