using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.DynamicPlanning
{
    class ClimbStairsSolution
    {
        public int ClimbStairs(int n)
        {
            if (n == 0 || n == 1 || n == 2)
            {
                return n;
            }
            int[] r = new int[n + 1];
            r[1] = 1;
            r[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                r[i] = r[i - 1] + r[i - 2];
            }
            return r[n];
        }
    }
}
