using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class _2395_FindSubarraysSolution
    {
        public bool FindSubarrays(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 1; i < nums.Length; i++)
            {
                int sum = nums[i] + nums[i - 1];
                if (set.Contains(sum))
                {
                    return true;
                }
                else
                {
                    set.Add(sum);
                }
            }
            return false;
        }
    }
}
