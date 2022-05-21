using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class RepeatedNTimesSolution
    {
        public int RepeatedNTimes(int[] nums)
        {
            var found = new HashSet<int>();
            foreach (var item in nums)
            {
                if (!found.Add(item))
                {
                    return item;
                }
            }
            return -1;
        }
    }
}
