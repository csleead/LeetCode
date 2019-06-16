using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem849
{
    public class Solution
    {
        public int MaxDistToClosest(int[] seats)
        {
            int maxDist = 0;

            int slow = 0, fast = 0;
            while(true)
            {
                while(slow < seats.Length && seats[slow] != 0)
                {
                    slow++;
                }

                if(slow >= seats.Length)
                {
                    return maxDist;
                }

                fast = slow + 1;
                while(fast < seats.Length && seats[fast] == 0)
                {
                    fast++;
                }

                if(slow == 0 || fast == seats.Length)
                {
                    maxDist = Math.Max(maxDist, fast - slow);
                }
                else
                {
                    int sequentialOpenSeatsCount = fast - slow;
                    int maxDistInSequence = (sequentialOpenSeatsCount % 2) == 0 ? sequentialOpenSeatsCount / 2 : sequentialOpenSeatsCount / 2 + 1;

                    maxDist = Math.Max(maxDist, maxDistInSequence);
                }

                slow = fast + 1;
            }
        }
    }
}
