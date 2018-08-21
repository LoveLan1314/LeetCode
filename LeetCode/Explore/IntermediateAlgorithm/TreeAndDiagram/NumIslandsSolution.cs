namespace LeetCode.Explore.IntermediateAlgorithm.TreeAndDiagram
{
    internal class NumIslandsSolution
    {
        private char[,] _grid;
        private int _row;
        private int _column;
        public int NumIslands(char[,] grid)
        {
            if (grid == null || grid.GetLength(0) == 0 || grid.GetLength(1) == 0)
            {
                return 0;
            }
            _grid = grid;
            _row = grid.GetLength(0);
            _column = grid.GetLength(1);

            int count = 0;

            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _column; j++)
                {
                    if (grid[i, j] == '1')
                    {
                        count++;
                        Combine(i, j);
                    }
                }
            }
            return count;
        }

        private void Combine(int x, int y)
        {
            _grid[x, y] = '2';
            if (x > _row - 1 && y > _column - 1)
            {
                return;
            }
            if (x < _row - 1 && _grid[x + 1, y] == '1')
            {
                Combine(x + 1, y);
            }
            if (y < _column - 1 && _grid[x, y + 1] == '1')
            {
                Combine(x, y + 1);
            }
            if (x > 0 && _grid[x - 1, y] == '1')
            {
                Combine(x - 1, y);
            }
            if (y > 0 && _grid[x, y - 1] == '1')
            {
                Combine(x, y - 1);
            }
        }
    }
}
