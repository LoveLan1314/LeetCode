using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class PartitionStringSolution
    {
        public int PartitionString(string s)
        {
            var count = 1;
            var set = new HashSet<char>();
            foreach (var item in s)
            {
                if (set.Contains(item))
                {
                    count++;
                    set = new HashSet<char>();
                }
                set.Add(item);
            }
            return count;
        }
    }
}
