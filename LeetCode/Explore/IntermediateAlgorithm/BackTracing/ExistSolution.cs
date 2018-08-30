namespace LeetCode.Explore.IntermediateAlgorithm.BackTracing
{
    internal class ExistSolution
    {
        public bool Exist(char[,] board, string word)
        {
            if(board.GetLength(0) == 0)
            {
                return false;
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    bool isExisted = Search(board, i, j, word, 0);
                    if (isExisted)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Search(char[,] board, int i, int j, string word, int idx)
        {
            if (idx >= word.Length)
            {
                return true;
            }
            if (i < 0 || i >= board.GetLength(0) || j < 0 || j >= board.GetLength(1) || board[i, j] != word[idx])
            {
                return false;
            }
            board[i, j] ^= (char)255;
            bool res = Search(board, i - 1, j, word, idx + 1) || Search(board, i + 1, j, word, idx + 1) ||
                Search(board, i, j - 1, word, idx + 1) || Search(board, i, j + 1, word, idx + 1);
            board[i, j] ^= (char)255;
            return res;
        }
    }
}
