using System.Collections.Generic;

namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    internal class SpiralOrderSolution
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            IList<int> result = new List<int>();
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            if (row == 0 || col == 0)
            {
                return result;
            }
            int up = 0, down = row - 1, left = 0, right = col - 1;
            while (true)
            {
                for (int j = left; j <= right; j++)
                {
                    result.Add(matrix[up, j]);
                }
                if (++up > down)
                {
                    break;
                }
                for (int i = up; i <= down; i++)
                {
                    result.Add(matrix[i, right]);
                }
                if (--right < left)
                {
                    break;
                }
                for (int j = right; j >= left; j--)
                {
                    result.Add(matrix[down, j]);
                }
                if (--down < up)
                {
                    break;
                }
                for (int i = down; i >= up; i--)
                {
                    result.Add(matrix[i, left]);
                }
                if (++left > right)
                {
                    break;
                }
            }
            return result;
        }
    }
}
