namespace LeetCode.SAOA
{
    internal sealed class CountNumbersWithUniqueDigitsSolution
    {
        public int CountNumbersWithUniqueDigits(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 10;
            }
            else
            {
                int result = 10;
                int cur = 9;
                for (int i = 0; i < n - 1; i++)
                {
                    cur *= 9 - i;
                    result += cur;
                }
                return result;
            }
        }
    }
}
