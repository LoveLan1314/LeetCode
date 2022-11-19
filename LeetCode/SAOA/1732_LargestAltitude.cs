using System;

namespace LeetCode.SAOA
{
    internal sealed class LargestAltitudeSolution
    {
        public int LargestAltitude(int[] gain)
        {
            int max = 0;
            int current = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                current += gain[i];
                max = Math.Max(max, current);
            }
            return max;
        }
    }
}
