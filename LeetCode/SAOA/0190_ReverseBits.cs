namespace LeetCode.SAOA
{
    internal sealed class ReverseBitsSolution
    {
        public uint ReverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32 && n > 0; i++)
            {
                result |= (n & 1) << (31 - i);
                n >>= 1;
            }
            return result;
        }

        private const uint M1 = 0x55555555; // 01010101010101010101010101010101
        private const uint M2 = 0x33333333; // 00110011001100110011001100110011
        private const uint M4 = 0x0f0f0f0f; // 00001111000011110000111100001111
        private const uint M8 = 0x00ff00ff; // 00000000111111110000000011111111

        public uint ReverseBits2(uint n)
        {
            n = n >> 1 & M1 | (n & M1) << 1;
            n = n >> 2 & M2 | (n & M2) << 2;
            n = n >> 4 & M4 | (n & M4) << 4;
            n = n >> 8 & M8 | (n & M8) << 8;
            return n >> 16 | n << 16;
        }
    }
}
