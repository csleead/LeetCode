using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem933
{
    // Write a class RecentCounter to count recent requests.
    // It has only one method: ping(int t), where t represents some time in milliseconds.
    // Return the number of pings that have been made from 3000 milliseconds ago until now.
    // Any ping with time in [t - 3000, t] will count, including the current ping.
    // It is guaranteed that every call to ping uses a strictly larger value of t than before.
    // Inputs:
    // - Each test case will have at most 10000 calls to ping.
    // - Each test case will call ping with strictly increasing values of t.
    // - Each call to ping will have 1 <= t <= 10^9.
    public class RecentCounter
    {
        private static readonly int Range = 3000;
        private readonly IList<int> _times = new List<int>(10000);
        private int _lastIndexInTimeRange = 0;

        public int Ping(int t)
        {
            _times.Add(t);
            while(_times[_lastIndexInTimeRange] < t - Range)
            {
                _lastIndexInTimeRange++;
            }
            return _times.Count - _lastIndexInTimeRange;
        }
    }
}
