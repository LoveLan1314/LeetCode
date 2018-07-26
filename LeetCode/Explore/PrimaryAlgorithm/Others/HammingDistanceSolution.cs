using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Others
{
    class HammingDistanceSolution
    {
        public int HammingDistance(int x, int y)
        {
            int z = x ^ y;
            int result = 0;
            int m = 1;
            while (m > 0)
            {
                if ((m & z) > 0)
                {
                    result++;
                }
                m = m << 1;
            }
            return result;
        }

        public int HammingDistance2(int x, int y)
        {
            int result = 0;
            int m = 1;
            while (m > 0)
            {
                if ((m & x) != (m & y))
                {
                    result++;
                }
                m = m << 1;
            }
            return result;
        }
    }
}
