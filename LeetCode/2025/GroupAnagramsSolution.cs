using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2025
{
    internal sealed class GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var data = new Dictionary<string, List<string>>();
            foreach (var item in strs)
            {
                var array = item.ToArray();
                Array.Sort(array);
                var key = new string(array);
                if (data.TryGetValue(key, out var list))
                {
                    list.Add(item);
                }
                else
                {
                    data.Add(key, new List<string> { item });
                }
            }
            return data.Select(i => i.Value.ToList() as IList<string>).ToList();
        }
    }
}
