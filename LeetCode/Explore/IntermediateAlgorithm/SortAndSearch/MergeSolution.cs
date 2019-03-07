using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Explore.IntermediateAlgorithm.SortAndSearch
{
    internal class MergeSolution
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            if(intervals.Count == 0)
            {
                return new List<Interval>();
            }
            List<Interval> result = new List<Interval>();
            List<Interval> list = intervals.Cast<Interval>().ToList();
            list.Sort(new IntervalCompare());
            result.Add(list[0]);
            foreach (var item in list)
            {
                if (result.Last().end >= item.start)
                {
                    result.Last().end = System.Math.Max(result.Last().end, item.end);
                }
                else
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public class IntervalCompare : IComparer<Interval>
        {
            public int Compare(Interval x, Interval y)
            {
                if (x.start > y.start)
                {
                    return 1;
                }
                else if (x.start < y.start)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public IList<Interval> Merge1(IList<Interval> intervals)
        {
            List<Interval> result = new List<Interval>();
            if(intervals == null || intervals.Count < 1)
            {
                return result;
            }
            List<Interval> list = intervals.OrderBy(i => i.start).ToList();
            Interval pre = null;
            foreach (var item in list)
            {
                if(pre == null || pre.end < item.start)
                {
                    result.Add(item);
                    pre = item;
                }
                else if(pre.end < item.end)
                {
                    pre.end = item.end;
                }
            }
            return result;
        }
    }
}
