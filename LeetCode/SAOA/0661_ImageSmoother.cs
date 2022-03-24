using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class ImageSmootherSolution
    {
        public int[][] ImageSmoother(int[][] img)
        {
            var n = img.Length;
            var m = img[0].Length;
            var result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    var list = new List<int>();
                    if (i - 1 >= 0)
                    {
                        if (j - 1 >= 0)
                        {
                            list.Add(img[i - 1][j - 1]);
                        }
                        list.Add(img[i - 1][j]);
                        if (j + 1 < m)
                        {
                            list.Add(img[i - 1][j + 1]);
                        }
                    }

                    if (j - 1 >= 0)
                    {
                        list.Add(img[i][j - 1]);
                    }
                    list.Add(img[i][j]);
                    if (j + 1 < m)
                    {
                        list.Add(img[i][j + 1]);
                    }

                    if (i + 1 < n)
                    {
                        if (j - 1 >= 0)
                        {
                            list.Add(img[i + 1][j - 1]);
                        }
                        list.Add(img[i + 1][j]);
                        if (j + 1 < m)
                        {
                            list.Add(img[i + 1][j + 1]);
                        }
                    }

                    result[i][j] = list.Sum() / list.Count;
                }
            }
            return result;
        }
    }
}
