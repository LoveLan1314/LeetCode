using System;

namespace LeetCode.SAOA
{
    internal sealed class MaxPointsSolution
    {
        public int MaxPoints(int[][] points)
        {
            int n = points.Length;
            int res = 1;
            for (int i = 0; i < n; i++)
            {
                var x = points[i];
                for (int j = i + 1; j < n; j++)
                {
                    var y = points[j];
                    int count = 2;
                    for (int k = j + 1; k < n; k++)
                    {
                        var z = points[k];
                        int value1 = (y[1] - x[1]) * (z[0] - y[0]);
                        int value2 = (z[1] - y[1]) * (y[0] - x[0]);
                        if (value1 == value2)
                        {
                            count++;
                        }
                    }
                    res = Math.Max(res, count);
                }
            }
            return res;
        }
    }
}
