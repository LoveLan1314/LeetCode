using System;
using System.Collections;

namespace LeetCode.Explore.PrimaryAlgorithm.Others
{
    class ReverseBitsSolution
    {
        public uint ReverseBits(uint n)
        {
            var bits = new BitArray(BitConverter.GetBytes(n));
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                if (bits[i])
                {
                    result = result | 1;
                }
                if(i != 31)
                {
                    result = result << 1;
                }
            }
            return result;
        }
    }
}
