using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.ArrayAndString
{
    class SetZeroesSolution
    {
        public void SetZeroes(int[,] matrix)
        {
            int len1 = matrix.GetLength(0);
            if (len1 == 0)
            {
                return;
            }
            int len2 = matrix.GetLength(1);
            if (len2 == 0)
            {
                return;
            }
            bool[] rows = new bool[len1];
            bool[] cols = new bool[len2];
            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rows[i] = true;
                        cols[j] = true;
                    }
                }
            }
            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (rows[i] || cols[j])
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }
    }
}
