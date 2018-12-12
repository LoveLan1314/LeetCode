namespace LeetCode.Explore.IntermediateAlgorithm.Math
{
    internal class TrailingZeroesSolution
    {
        public int TrailingZeroes(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                n /= 5;
                sum += n;
            }
            return sum;
        }
    }
}
