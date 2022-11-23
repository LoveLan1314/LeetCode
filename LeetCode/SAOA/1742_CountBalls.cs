using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CountBallsSolution
    {
        public int CountBalls(int lowLimit, int highLimit)
        {
            var boxPairs = new Dictionary<int, int>();
            int result = 0;
            for (int i = lowLimit; i <= highLimit; i++)
            {
                int box = 0, x = i;
                while (x != 0)
                {
                    box += x % 10;
                    x /= 10;
                }
                if (boxPairs.TryGetValue(box, out int value))
                {
                    boxPairs[box] = value + 1;
                }
                else
                {
                    boxPairs[box] = 1;
                }
                result = Math.Max(result, boxPairs[box]);
            }
            return result;
        }
    }
}
