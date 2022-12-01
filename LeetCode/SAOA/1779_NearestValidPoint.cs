using System;

namespace LeetCode.SAOA
{
    internal sealed class _1779_NearestValidPointSolution
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            int result = -1;
            int minDistance = int.MaxValue;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] == x || points[i][1] == y)
                {
                    int distance = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                    if (distance < minDistance)
                    {
                        result = i;
                        minDistance = distance;
                    }
                }
            }
            return result;
        }
    }
}
