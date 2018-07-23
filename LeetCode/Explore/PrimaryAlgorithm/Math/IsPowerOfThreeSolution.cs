using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Math
{
    class IsPowerOfThreeSolution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n == 1 || n == 3)
            {
                return true;
            }
            return GetIsPowerOfThree(n);
        }
        public bool GetIsPowerOfThree(int n)
        {
            if (n % 3 == 0)
            {
                int m = n / 3;
                if (m == 3)
                {
                    return true;
                }
                else if (m < 3)
                {
                    return false;
                }
                else
                {
                    return GetIsPowerOfThree(m);
                }
            }
            else
            {
                return false;
            }
        }
    }
}
