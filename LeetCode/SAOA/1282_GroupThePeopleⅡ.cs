﻿using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class GroupThePeopleSolutionⅡ
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            Dictionary<int, IList<int>> groups = new Dictionary<int, IList<int>>();
            int n = groupSizes.Length;
            for (int i = 0; i < n; i++)
            {
                int size = groupSizes[i];
                groups.TryAdd(size, new List<int>());
                groups[size].Add(i);
            }
            IList<IList<int>> groupList = new List<IList<int>>();
            foreach (KeyValuePair<int, IList<int>> pair in groups)
            {
                int size = pair.Key;
                IList<int> people = pair.Value;
                int groupCount = people.Count / size;
                for (int i = 0; i < groupCount; i++)
                {
                    IList<int> group = new List<int>();
                    int start = i * size;
                    for (int j = 0; j < size; j++)
                    {
                        group.Add(people[start + j]);
                    }
                    groupList.Add(group);
                }
            }
            return groupList;
        }
    }
}
