using System.Collections.Generic;

namespace LeetCode.DataStructure.ArrayAndString
{
    internal sealed class FindDiagonalOrderSolution
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            if (matrix.Length == 0)
            {
                return new int[] { };
            }
            int m = matrix.Length;
            int n = matrix[0].Length;
            List<int> result = new List<int>();
            for (int curveLine = 0; curveLine < m + n - 1; curveLine++)
            {
                int rowBegin;
                int rowEnd;
                if (curveLine < n - 1)
                {
                    rowBegin = 0;
                }
                else
                {
                    rowBegin = curveLine + 1 - n;
                }
                if (curveLine + 1 >= m)
                {
                    rowEnd = m - 1;
                }
                else
                {
                    rowEnd = curveLine;
                }

                if (curveLine % 2 == 1)
                {
                    for (int i = rowBegin; i <= rowEnd; i++)
                    {
                        result.Add(matrix[i][curveLine - i]);
                    }
                }
                else
                {
                    for (int i = rowEnd; i >= rowBegin; i--)
                    {
                        result.Add(matrix[i][curveLine - i]);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
