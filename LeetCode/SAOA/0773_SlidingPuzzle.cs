using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class SlidingPuzzleSolution
    {
        public int SlidingPuzzle(int[][] board)
        {
            string target = "123450";
            var boardStr = GetString(board);
            if (boardStr == target)
            {
                return 0;
            }
            var set = new HashSet<string>
            {
                boardStr
            };
            var queue = new Queue<int[][]>();
            queue.Enqueue(board);
            int setp = 0;
            while (queue.Count > 0)
            {
                setp++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    var nextValues = Get(current);
                    for (int j = 0; j < nextValues.Count; j++)
                    {
                        var nextValue = GetString(nextValues[j]);
                        if (nextValue == target)
                        {
                            return setp;
                        }
                        if (!set.Contains(nextValue))
                        {
                            set.Add(nextValue);
                            queue.Enqueue(nextValues[j]);
                        }
                    }
                }
            }
            return -1;
        }

        private string GetString(int[][] current)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sb.Append(current[i][j]);
                }
            }
            return sb.ToString();
        }

        private List<int[][]> Get(int[][] current)
        {
            var result = new List<int[][]>();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (current[i][j] == 0)
                    {
                        if (i == 0)
                        {
                            current[i][j] = current[i + 1][j];
                            current[i + 1][j] = 0;
                            result.Add(GetNew(current));
                            current[i + 1][j] = current[i][j];
                            current[i][j] = 0;
                        }
                        else
                        {
                            current[i][j] = current[i - 1][j];
                            current[i - 1][j] = 0;
                            result.Add(GetNew(current));
                            current[i - 1][j] = current[i][j];
                            current[i][j] = 0;
                        }

                        if (j != 0)
                        {
                            current[i][j] = current[i][j - 1];
                            current[i][j - 1] = 0;
                            result.Add(GetNew(current));
                            current[i][j - 1] = current[i][j];
                            current[i][j] = 0;
                        }
                        if (j != 2)
                        {
                            current[i][j] = current[i][j + 1];
                            current[i][j + 1] = 0;
                            result.Add(GetNew(current));
                            current[i][j + 1] = current[i][j];
                            current[i][j] = 0;
                        }
                    }
                }
            }
            return result;
        }

        private int[][] GetNew(int[][] current)
        {
            return new int[][]
            {
                new int[] {current[0][0],current[0][1], current[0][2]},
                new int[] {current[1][0],current[1][1], current[1][2]}
            };
        }
    }
}
