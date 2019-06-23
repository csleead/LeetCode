using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem539
{
    public class Solution
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            var hasMinute = new bool[24 * 60];
            Array.Fill(hasMinute, false);

            foreach(var pt in timePoints)
            {
                var m = MinutesSince0000(pt);
                if(hasMinute[m])
                    return 0;
                else
                    hasMinute[m] = true;
            }

            int first = -1, last = -1;

            int minDist = int.MaxValue;
            int previous = -1;
            for(int i = 0; i < hasMinute.Length; i++)
            {
                if(hasMinute[i])
                {
                    if(previous != -1)
                    {
                        var dist = i - previous;
                        minDist = Math.Min(dist, minDist);

                        if(minDist == 1)
                        {
                            return 1;
                        }
                    }

                    if(first == -1)
                        first = i;

                    last = i;
                    previous = i;
                }
            }

            minDist = Math.Min(minDist, 24 * 60 - last + first);

            return minDist;
        }

        private int MinutesSince0000(string pt)
        {
            return 60 * int.Parse(pt.Substring(0, 2)) + int.Parse(pt.Substring(3, 2));
        }
    }
}
