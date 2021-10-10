namespace LeetCode.SAOA
{
    internal sealed class ArrangeCoinsSolution
    {
        public int ArrangeCoins(int n)
        {
            int result = 0;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (n >= i)
                {
                    result++;
                    n -= i;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}
