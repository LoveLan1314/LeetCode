using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class FrequencySortSolution
    {
        public string FrequencySort(string s)
        {
            var list = s.ToArray();
            var pairs = new Dictionary<char, int>();
            foreach (var item in list)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item]++;
                }
                else
                {
                    pairs.Add(item, 1);
                }
            }
            var sb = new StringBuilder();
            foreach (var item in pairs.OrderByDescending(i => i.Value))
            {
                sb.Append(item.Key, item.Value);
            }
            return sb.ToString();
        }
    }
}
