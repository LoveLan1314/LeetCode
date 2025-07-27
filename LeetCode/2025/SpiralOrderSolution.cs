using System.Collections;
using System.Collections.Generic;

namespace LeetCode._2025
{
    internal sealed class SpiralOrderSolution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var order = new List<int>();
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return order;
            }
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            bool[,] visited = new bool[rows, columns];
            int total = rows * columns;
            int row = 0;
            int column = 0;
            int[][] directions = [[0, 1], [1, 0], [0, -1], [-1, 0]];
            int directionIndex = 0;
            for (int i = 0; i < total; i++)
            {
                order.Add(matrix[row][column]);
                visited[row, column] = true;
                int nextRow = row + directions[directionIndex][0], nextColumn = column + directions[directionIndex][1];
                if (nextRow < 0 || nextRow >= rows || nextColumn < 0 || nextColumn >= columns || visited[nextRow, nextColumn])
                {
                    directionIndex = (directionIndex + 1) % 4;
                }
                row += directions[directionIndex][0];
                column += directions[directionIndex][1];
            }
            return order;
        }
    }
}