namespace LeetCode.SAOA
{
    internal sealed class CountPrimeSetBitsSolution
    {
        public int CountPrimeSetBits(int left, int right)
        {
            var ans = 0;
            for (int x = left; x <= right; ++x)
            {
                if (IsPrime(BitCount(x)))
                {
                    ++ans;
                }
            }
            return ans;
        }

        private bool IsPrime(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private int BitCount(int i)
        {
            i -= ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            i = (i + (i >> 4)) & 0x0f0f0f0f;
            i += (i >> 8);
            i += (i >> 16);
            return i & 0x3f;
        }
    }
}
