using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class CountConsistentStringsSolution
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            var set = new HashSet<char>(allowed.ToCharArray().Distinct());
            var count = 0;
            foreach (var item in words)
            {
                var match = true;
                foreach (var c in item)
                {
                    if (!set.Contains(c))
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
