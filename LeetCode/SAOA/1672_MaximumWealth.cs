using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MaximumWealthSolution
    {
        public int MaximumWealth(int[][] accounts)
        {
            var max = 0;
            foreach (var item in accounts)
            {
                var sum = item.Sum();
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
    }
}
