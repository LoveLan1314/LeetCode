using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Array
{
    class RotateImgSolution
    {
        public void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    int swap = matrix[i, j];
                    matrix[i, j] = matrix[n - 1 - j, i];
                    matrix[n - 1 - j, i] = matrix[n - 1 - i, n - 1 - j];
                    matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i];
                    matrix[j, n - 1 - i] = swap;
                }
            }
        }
    }
}
