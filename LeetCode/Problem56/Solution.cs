using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem56
{
    public class Solution
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            if(intervals.Count == 0)
                return new Interval[0];

            var sortedIntervals = new Queue<Interval>(intervals.OrderBy(i => i.start));

            var result = new List<Interval>();

            var current = sortedIntervals.Dequeue();
            while(sortedIntervals.Count > 0)
            {
                var next = sortedIntervals.Dequeue();
                if(Overlap(current, next))
                {
                    current = MergeTwo(current, next);
                }
                else
                {
                    result.Add(current);
                    current = next;
                }
            }
            result.Add(current);

            return result;
        }

        private bool Overlap(Interval first, Interval second)
        {
            if(first.start > second.start)
                return Overlap(second, first);

            return first.end >= second.start;
        }

        private Interval MergeTwo(Interval first, Interval second)
        {
            return new Interval
            {
                start = Math.Min(first.start, second.start),
                end = Math.Max(first.end, second.end),
            };
        }
    }
}
