using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm
{
    class IsValidSudokuSolution
    {
        public bool IsValidSudoku(char[,] board)
        {
            foreach (var item in board)
            {
                //使用HashSet效率明显不如使用List
                //HashSet<char> rowSet = new HashSet<char>();
                //HashSet<char> colSet = new HashSet<char>();
                List<char> rowSet = new List<char>();
                List<char> colSet = new List<char>();
                for (int i = 0; i < 9; i++)
                {
                    rowSet.Clear();
                    colSet.Clear();
                    for (int j = 0; j < 9; j++)
                    {
                        if (i % 3 == 0 && j % 3 == 0)
                        {
                            if (!CheckBlock(board, i, j))
                            {
                                return false;
                            }
                        }
                        if (board[i, j] != '.')
                        {
                            if (rowSet.Contains(board[i, j]))
                            {
                                return false;
                            }
                            rowSet.Add(board[i, j]);
                        }
                        if (board[j, i] != '.')
                        {
                            if (colSet.Contains(board[j, i]))
                            {
                                return false;
                            }
                            colSet.Add(board[j, i]);
                        }
                    }
                }
            }
            return true;
        }

        private bool CheckBlock(char[,] board, int row, int col)
        {
            List<char> blockSet = new List<char>();
            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    if (board[i, j] != '.')
                    {
                        if (blockSet.Contains(board[i, j]))
                        {
                            return false;
                        }
                        blockSet.Add(board[i, j]);
                    }
                }
            }
            return true;
        }
    }
}
