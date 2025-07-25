namespace LeetCode._2025
{
    internal sealed class SetZeroesSolution
    {
        public void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            bool[] row = new bool[m];
            bool[] col = new bool[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        row[i] = true;
                        col[j] = true;
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (row[i] || col[j])
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}