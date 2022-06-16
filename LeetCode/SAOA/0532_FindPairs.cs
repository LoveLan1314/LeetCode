using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindPairsSolution
    {
        public int FindPairs(int[] nums, int k)
        {
            var visited = new HashSet<int>();
            var result = new HashSet<int>();
            foreach (var item in nums)
            {
                if (visited.Contains(item - k))
                {
                    result.Add(item - k);
                }
                if (visited.Contains(item + k))
                {
                    result.Add(item);
                }
                visited.Add(item);
            }
            return result.Count;
        }
    }
}
