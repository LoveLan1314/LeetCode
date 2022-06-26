namespace LeetCode.SAOA
{
    internal sealed class CheckXMatrixSolution
    {
        public bool CheckXMatrix(int[][] grid)
        {
            var n = grid.Length;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 || j == n - 1)
                        {
                            if (grid[i][j] == 0)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (grid[i][j] != 0)
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j || i + j == n -1)
                        {
                            if (grid[i][j] == 0)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (grid[i][j] != 0)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
