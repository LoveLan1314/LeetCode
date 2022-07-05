using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class MyCalendar
    {
        private readonly IList<Tuple<int, int>> _booked;

        public MyCalendar()
        {
            _booked = new List<Tuple<int, int>>();
        }

        public bool Book(int start, int end)
        {
            foreach (var tuple in _booked)
            {
                int l = tuple.Item1, r = tuple.Item2;
                if (l < end && start < r)
                {
                    return false;
                }
            }
            _booked.Add(new Tuple<int, int>(start, end));
            return true;
        }
    }
}
