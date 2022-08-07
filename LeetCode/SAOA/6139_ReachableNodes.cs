using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class ReachableNodesSolution
    {
        public int ReachableNodes(int n, int[][] edges, int[] restricted)
        {
            var pairs = new Dictionary<int, List<int>>();
            foreach (var item in edges)
            {
                var a = item[0];
                var b = item[1];
                if (pairs.TryGetValue(a, out var list))
                {
                    list.Add(b);
                }
                else
                {
                    pairs.Add(a, new List<int>() { b });
                }
                if (pairs.TryGetValue(b, out var list2))
                {
                    list2.Add(a);
                }
                else
                {
                    pairs.Add(b, new List<int>() { a });
                }
            }
            var set = new HashSet<int>() { 0 };
            CalcNodes(pairs, pairs[0], restricted, set);
            return set.Count;
        }

        private void CalcNodes(Dictionary<int, List<int>> pairs, List<int> items, int[] restricted, HashSet<int> set)
        {
            foreach (var item in items)
            {
                if (!restricted.Contains(item) && !set.Contains(item))
                {
                    set.Add(item);
                    if (pairs.TryGetValue(item, out var list))
                    {
                        CalcNodes(pairs, list, restricted, set);
                    }
                }
            }
        }
    }
}
