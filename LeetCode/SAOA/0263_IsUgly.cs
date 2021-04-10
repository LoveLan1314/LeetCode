namespace LeetCode.SAOA
{
    internal sealed class IsUglySolution
    {
        public bool IsUgly(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            int[] factors = new int[] { 2, 3, 5 };
            for (int i = 0; i < factors.Length; i++)
            {
                while (n % factors[i] == 0)
                {
                    n /= factors[i];
                }
            }
            return n == 1;
        }
    }
}
