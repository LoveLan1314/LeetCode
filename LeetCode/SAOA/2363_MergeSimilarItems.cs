using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class _2363_MergeSimilarItemsSolution
    {
        public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            var pairs = new Dictionary<int, int>();
            foreach (var item in items1)
            {
                pairs.Add(item[0], item[1]);
            }
            foreach (var item in items2)
            {
                if (!pairs.ContainsKey(item[0]))
                {
                    pairs.Add(item[0], item[1]);
                }
                else
                {
                    pairs[item[0]] += item[1];
                }
            }
            return pairs.OrderBy(i => i.Key).Select(i => new List<int>() { i.Key, i.Value } as IList<int>).ToList();
        }
    }
}
