using System;

namespace LeetCode.SAOA
{
    internal sealed class TrimMeanSolution
    {
        public double TrimMean(int[] arr)
        {
            var n = arr.Length;
            var removeCount = n / 20;
            Array.Sort(arr);
            var sum = 0;
            for (int i = removeCount; i < n - removeCount; i++)
            {
                sum += arr[i];
            }
            return (double)sum / (n - removeCount * 2);
        }
    }
}
