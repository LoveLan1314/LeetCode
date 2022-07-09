using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class LenLongestFibSubseqSolution
    {
        public int LenLongestFibSubseq(int[] arr)
        {
            var indices = new Dictionary<int, int>();
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                indices.Add(arr[i], i);
            }
            int[,] dp = new int[n, n];
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i - 1; j >= 0 && arr[j] * 2 > arr[i]; j--)
                {
                    int k = indices.ContainsKey(arr[i] - arr[j]) ? indices[arr[i] - arr[j]] : -1;
                    if (k >= 0)
                    {
                        dp[j, i] = Math.Max(dp[k, j] + 1, 3);
                    }
                    ans = Math.Max(ans, dp[j, i]);
                }
            }
            return ans;
        }
    }
}
