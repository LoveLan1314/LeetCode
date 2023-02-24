using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class _2357_MinimumOperationsSolution
    {
        public int MinimumOperations(int[] nums)
        {
            return nums.Where(i => i > 0).Distinct().Count();
        }
    }
}
