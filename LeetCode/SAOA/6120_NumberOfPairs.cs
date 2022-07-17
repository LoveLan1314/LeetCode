using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class NumberOfPairsSolution
    {
        public int[] NumberOfPairs(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }
            var count = 0;
            var surplus = 0;
            foreach (var item in dictionary)
            {
                count += item.Value / 2;
                surplus += item.Value % 2;
            }
            return new int[] { count, surplus };
        }
    }
}
