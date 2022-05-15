using System;

namespace LeetCode.SAOA
{
    internal sealed class MaxConsecutiveSolution
    {
        public int MaxConsecutive(int bottom, int top, int[] special)
        {
            if (special.Length == 0)
            {
                return top - bottom + 1;
            }
            Array.Sort(special);
            int max = 0;
            for (int i = 0; i <= special.Length; i++)
            {
                int current;
                if (i == 0)
                {
                    current = special[i] - bottom;
                }
                else if (i == special.Length)
                {
                    current = top - special[i - 1];
                }
                else
                {
                    current = special[i] - special[i - 1] - 1;
                }
                if (current > max)
                {
                    max = current;
                }
            }
            return max;
        }
    }
}
