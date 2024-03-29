﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class ReachNumberSolution
    {
        public int ReachNumber(int target)
        {
            target = Math.Abs(target);
            int k = 0;
            while (target > 0)
            {
                k++;
                target -= k;
            }
            return target % 2 == 0 ? k : k + 1 + k % 2;
        }
    }
}
