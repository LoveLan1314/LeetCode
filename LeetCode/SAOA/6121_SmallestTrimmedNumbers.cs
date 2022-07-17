using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class SmallestTrimmedNumbersSolution
    {
        public int[] SmallestTrimmedNumbers(string[] nums, int[][] queries)
        {
            var result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                var value = queries[i];
                var pairs = new Dictionary<int, string>();
                for (int j = 0; j < nums.Length; j++)
                {
                    var str = nums[j][^(value[1])..];
                    var newIndex = 0;
                    foreach (var item in str)
                    {
                        if (item == '0')
                        {
                            newIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (newIndex > 0)
                    {
                        if (newIndex == str.Length)
                        {
                            newIndex--;
                        }
                        str = str[newIndex..];
                    }
                    pairs.Add(j, str);
                }
                int index = 0;
                foreach (var item in pairs.OrderBy(i => i.Value.Length).ThenBy(i => i.Value).ThenBy(i => i.Key))
                {
                    if (value[0] - 1 == index)
                    {
                        result[i] = item.Key;
                        break;
                    }
                    index++;
                }
            }
            return result;
        }
    }
}
