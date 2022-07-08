using System;

namespace LeetCode.SAOA
{
    internal sealed class MinCostToMoveChipsSolution
    {
        public int MinCostToMoveChips(int[] position)
        {
            int even = 0, odd = 0;
            foreach (var pos in position)
            {
                if ((pos & 1) != 0)
                {
                    odd++;
                }
                else
                {
                    even++;
                }
            }
            return Math.Min(odd, even);
        }
    }
}
