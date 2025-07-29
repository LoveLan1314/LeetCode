namespace LeetCode._2025
{
    internal sealed class Rotate1Solution
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            int[,] matrix_new = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix_new[j, n - i - 1] = matrix[i][j];
                }
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix[i][j] = matrix_new[i, j];
                }
            }
        }
    }
}