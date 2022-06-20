using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class GroupThePeopleSolution
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var dict = new Dictionary<int, List<int>>();
            var result = new List<IList<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                var size = groupSizes[i];
                if (dict.TryGetValue(size, out var list) && list.Count < size)
                {
                    list.Add(i);
                }
                else
                {
                    list = new List<int>()
                    {
                        i
                    };
                    result.Add(list);
                    dict[size] = list;
                }
            }
            return result;
        }
    }
}
