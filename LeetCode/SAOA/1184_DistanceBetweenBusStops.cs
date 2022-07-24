using System;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class DistanceBetweenBusStopsSolution
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            var sum = distance.Sum();
            var length = 0;
            int left = Math.Min(start, destination);
            int right = Math.Max(start, destination);
            for (int i = left; i < right; i++)
            {
                length += distance[i];
            }
            return Math.Min(length, sum - length);
        }
    }
}
