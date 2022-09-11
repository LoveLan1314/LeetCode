using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MinGroupsSolution
    {
        public int MinGroups(int[][] intervals)
        {
            var list = new List<int[]>();
            for (int i = 0; i < intervals.Length; i++)
            {
                list.Add(new int[] { intervals[i][0], intervals[i][1] });
            }
            list = list.OrderBy(i => i[0]).ToList();
            var pairs = new List<List<int[]>>();
            foreach (var item in list)
            {
                var start = item[0];
                var end = item[1];
                var isMatch = false;
                foreach (var container in pairs)
                {
                    isMatch = true;
                    foreach (var data in container)
                    {
                        if ((start >= data[0] && start <= data[1]) ||
                            (end >= data[0] && end <= data[1]))
                        {
                            isMatch = false;
                            break;
                        }
                    }
                    if (isMatch)
                    {
                        container.Add(item);
                        break;
                    }
                }
                if (!isMatch)
                {
                    pairs.Add(new List<int[]>() { item });
                }
            }
            return pairs.Count;
        }
    }
}
