using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class _2341_NumberOfPairsSolution
    {
        public int[] NumberOfPairs(int[] nums)
        {
            int matchCount = 0;
            HashSet<int> result = new HashSet<int>();
            foreach (int i in nums)
            {
                if (result.Contains(i))
                {
                    matchCount++;
                    result.Remove(i);
                }
                else
                {
                    result.Add(i);
                }
            }
            return new int[] { matchCount, nums.Length - (matchCount * 2) };
        }
    }
}
