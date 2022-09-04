namespace LeetCode.SAOA
{
    internal sealed class NumSpecialSolution
    {
        public int NumSpecial(int[][] mat)
        {
            var result = 0;
            var rows = mat.Length;
            var cols = mat[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        var match = true;
                        for (int x = 0; x < rows; x++)
                        {
                            if (x != i && mat[x][j] != 0)
                            {
                                match = false;
                                break;
                            }
                        }
                        if (match)
                        {
                            for (int x = 0; x < cols; x++)
                            {
                                if (x != j && mat[i][x] != 0)
                                {
                                    match = false;
                                    break;
                                }
                            }
                        }
                        if (match)
                        {
                            result++;
                        }
                    }
                }
            }
            return result;
        }
    }
}
