namespace LeetCode.SAOA
{
    internal sealed class OddCellsSolution
    {
        public int OddCells(int m, int n, int[][] indices)
        {
            var data = new int[m, n];
            foreach (var item in indices)
            {
                for (int i = 0; i < n; i++)
                {
                    data[item[0], i]++;
                }
                for (int i = 0; i < m; i++)
                {
                    data[i, item[1]]++;
                }
            }
            var result = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (data[i, j] % 2 == 1)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
