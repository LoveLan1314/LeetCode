namespace LeetCode.SAOA
{
    internal sealed class SumZeroSolution
    {
        public int[] SumZero(int n)
        {
            var result = new int[n];
            for (int i = 0; i < n / 2; i++)
            {
                int val = i + 1;
                result[i * 2] = -val;
                result[i * 2 + 1] = val;
            }
            if (n % 2 == 1)
            {
                result[n - 1] = 0;
            }
            return result;
        }
    }
}
