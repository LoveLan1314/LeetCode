using System;

namespace LeetCode.SAOA
{
    internal sealed class LargestLocalSolution
    {
        public int[][] LargestLocal(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var result = new int[n - 2][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new int[m - 2];
                for (int j = 0; j < result[i].Length; j++)
                {
                    result[i][j] = CalcMax(i, j, grid);
                }
            }
            return result;
        }

        private int CalcMax(int i, int j, int[][] grid)
        {
            var max = int.MinValue;
            max = Math.Max(max, grid[i][j]);
            max = Math.Max(max, grid[i][j + 1]);
            max = Math.Max(max, grid[i][j + 2]);
            max = Math.Max(max, grid[i + 1][j]);
            max = Math.Max(max, grid[i + 1][j + 1]);
            max = Math.Max(max, grid[i + 1][j + 2]);
            max = Math.Max(max, grid[i + 2][j]);
            max = Math.Max(max, grid[i + 2][j + 1]);
            max = Math.Max(max, grid[i + 2][j + 2]);
            return max;
        }
    }
}
