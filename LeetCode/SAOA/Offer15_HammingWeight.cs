namespace LeetCode.SAOA
{
    internal sealed class HammingWeightSolution
    {
        public int HammingWeight(uint n)
        {
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & (1 << i)) != 0)
                {
                    result++;
                }
            }
            return result;
        }

        public int HammingWeight1(uint n)
        {
            n = (n & 0x55555555) + ((n >> 1) & 0x55555555);
            n = (n & 0x33333333) + ((n >> 2) & 0x33333333);
            n = (n & 0x0f0f0f0f) + ((n >> 4) & 0x0f0f0f0f);
            n = (n & 0x00ff00ff) + ((n >> 8) & 0x00ff00ff);
            n = (n & 0x0000ffff) + ((n >> 16) & 0x0000ffff);
            return (int)n;
        }
    }
}
