using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class MyCalendarTwo
    {
        private readonly List<Tuple<int, int>> booked;
        private readonly List<Tuple<int, int>> overlaps;

        public MyCalendarTwo()
        {
            booked = new List<Tuple<int, int>>();
            overlaps = new List<Tuple<int, int>>();
        }

        public bool Book(int start, int end)
        {
            foreach (Tuple<int, int> tuple in overlaps)
            {
                int l = tuple.Item1, r = tuple.Item2;
                if (l < end && start < r)
                {
                    return false;
                }
            }
            foreach (Tuple<int, int> tuple in booked)
            {
                int l = tuple.Item1, r = tuple.Item2;
                if (l < end && start < r)
                {
                    overlaps.Add(new Tuple<int, int>(Math.Max(l, start), Math.Min(r, end)));
                }
            }
            booked.Add(new Tuple<int, int>(start, end));
            return true;
        }
    }
}
