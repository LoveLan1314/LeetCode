using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class ArrayRankTransformSolution
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                pairs.Add(i, arr[i]);
            }
            var order = 0;
            var prevValue = int.MinValue;
            foreach (var item in pairs.OrderBy(i => i.Value))
            {
                if (order == 0 || prevValue != item.Value)
                {
                    order++;
                }
                arr[item.Key] = order;
                prevValue = item.Value;
            }
            return arr;
        }
    }
}
