using System;

namespace LeetCode.SAOA
{
    internal sealed class MaxIceCreamSolution
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);
            int used = 0;
            int count = 0;
            for (int i = 0; i < costs.Length; i++)
            {
                used += costs[i];
                if (used <= coins)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}
