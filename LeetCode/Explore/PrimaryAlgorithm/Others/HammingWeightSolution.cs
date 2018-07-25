using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Others
{
    class HammingWeightSolution
    {
        public int HammingWeight(uint n)
        {
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                result += (int)(n % 2);
                n /= 2;
            }
            return result;
        }
        public int HammingWeight2(uint n)
        {
            int result = 0;
            uint m = 1;
            while (m > 0)
            {
                if ((m & n) > 0)
                {
                    result++;
                }
                m = m << 1;
            }
            return result;
        }
    }
}
