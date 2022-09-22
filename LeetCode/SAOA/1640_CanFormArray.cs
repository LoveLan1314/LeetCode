using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CanFormArraySolution
    {
        public bool CanFormArray(int[] arr, int[][] pieces)
        {
            int n = arr.Length, m = pieces.Length;
            var index = new Dictionary<int, int>();
            for (int i = 0; i < m; i++)
            {
                index.Add(pieces[i][0], i);
            }
            for (int i = 0; i < n;)
            {
                if (!index.ContainsKey(arr[i]))
                {
                    return false;
                }
                int j = index[arr[i]], len = pieces[j].Length;
                for (int k = 0; k < len; k++)
                {
                    if (arr[i + k] != pieces[j][k])
                    {
                        return false;
                    }
                }
                i += len;
            }
            return true;
        }
    }
}
