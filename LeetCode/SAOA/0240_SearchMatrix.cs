namespace LeetCode.SAOA
{
    internal sealed class SearchMatrixSolution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int len = matrix.Length;
            int row = matrix[0].Length;
            if (len == 0 || row == 0)
            {
                return false;
            }
            if (matrix[0][0] > target || matrix[len - 1][row - 1] < target)
            {
                return false;
            }
            int x = len - 1;
            int y = 0;
            while (true)
            {
                if (matrix[x][y] > target)
                {
                    x--;
                }
                else if (matrix[x][y] < target)
                {
                    y++;
                }
                else
                {
                    return true;
                }
                if (x < 0 || y >= row)
                {
                    return false;
                }
            }
        }
    }
}
