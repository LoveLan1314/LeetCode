using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class SnakesAndLaddersSolution
    {
        public int SnakesAndLadders(int[][] board)
        {
            int n = board.Length;
            int target = n * n;
            var start = 1;
            if (start == target)
            {
                return 0;
            }

            var set = new HashSet<int>()
            {
                start
            };
            var queue = new Queue<int>();
            queue.Enqueue(start);
            int step = 0;
            while (queue.Count > 0)
            {
                step++;
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    for (int j = 1; j <= 6; j++)
                    {
                        var next = current + j;
                        if (next > target)
                        {
                            break;
                        }
                        var nextValue = GetValue(board, next);
                        if (nextValue != -1)
                        {
                            next = nextValue;
                        }
                        if (next == target)
                        {
                            return step;
                        }
                        if (!set.Contains(next))
                        {
                            set.Add(next);
                            queue.Enqueue(next);
                        }
                    }
                }
            }
            return -1;
        }

        private int GetValue(int[][] board, int number)
        {
            int n = board.Length;
            int rowCount = (int)Math.Ceiling((decimal)number / n);
            var row = n - rowCount;
            int column;
            if (rowCount % 2 == 0)
            {
                column = n - (number - n * (rowCount - 1));
            }
            else
            {
                column = number - n * (rowCount - 1) - 1;
            }
            return board[row][column];
        }
    }
}
