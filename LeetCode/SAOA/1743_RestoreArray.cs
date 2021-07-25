using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class RestoreArraySolution
    {
        public int[] RestoreArray(int[][] adjacentPairs)
        {
            var pairs = new Dictionary<int, List<int>>();
            for (int i = 0; i < adjacentPairs.Length; i++)
            {
                var num1 = adjacentPairs[i][0];
                var num2 = adjacentPairs[i][1];
                if (pairs.TryGetValue(num1, out var list))
                {
                    list.Add(num2);
                }
                else
                {
                    pairs.Add(num1, new List<int>() { num2 });
                }
                if (pairs.TryGetValue(num2, out var list2))
                {
                    list2.Add(num1);
                }
                else
                {
                    pairs.Add(num2, new List<int>() { num1 });
                }
            }
            int[] result = new int[adjacentPairs.Length + 1];
            foreach (var item in pairs)
            {
                if (item.Value.Count == 1)
                {
                    result[0] = item.Key;
                    result[1] = item.Value[0];
                    break;
                }
            }
            for (int i = 2; i < adjacentPairs.Length + 1; i++)
            {
                var list = pairs[result[i - 1]];
                result[i] = list[0] == result[i - 2] ? list[1] : list[0];
            }
            return result;
        }
    }
}
