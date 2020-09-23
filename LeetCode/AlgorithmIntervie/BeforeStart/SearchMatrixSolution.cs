namespace LeetCode.AlgorithmIntervie.BeforeStart
{
    internal sealed class SearchMatrixSolution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int len = matrix.GetLength(0);
            int row = matrix.GetLength(1);
            if (len == 0 || row == 0)
            {
                return false;
            }
            if (target < matrix[0, 0] || target > matrix[len - 1, row - 1])
            {
                return false;
            }
            //注意点：从右上角开始比对
            int x = len - 1;
            int y = 0;
            while (true)
            {
                if (matrix[x, y] > target)
                {
                    x--;
                }
                else if (matrix[x, y] < target)
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
