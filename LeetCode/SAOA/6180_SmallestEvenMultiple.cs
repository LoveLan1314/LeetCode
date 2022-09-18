namespace LeetCode.SAOA
{
    internal sealed class SmallestEvenMultipleSolution
    {
        public int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0)
            {
                return n;
            }
            else
            {
                return 2 * n;
            }
        }
    }
}
