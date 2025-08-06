namespace LeetCode._2025
{
    internal sealed class SearchMatrixSolution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            foreach (var row in matrix)
            {
                foreach (var item in row)
                {
                    if (item == target)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
