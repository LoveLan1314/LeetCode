using System;

namespace LeetCode.SAOA
{
    internal sealed class _1769_MinOperationsSolution
    {
        public int[] MinOperations(string boxes)
        {
            int n = boxes.Length;
            var result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if (boxes[j] == '1')
                    {
                        sum += Math.Abs(i - j);
                    }
                }
                result[i] = sum;
            }
            return result;
        }
    }
}
