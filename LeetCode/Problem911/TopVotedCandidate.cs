using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem911
{
    public class TopVotedCandidate
    {
        private readonly int[] _times;
        private readonly int[] _leadings;

        public TopVotedCandidate(int[] persons, int[] times)
        {
            _times = times;
            _leadings = ComputeLeadings(persons);
        }

        public int Q(int t)
        {
            var timesIndex = Array.BinarySearch(_times, t);
            if(timesIndex < 0)
            {
                timesIndex = ~timesIndex - 1;
            }

            return _leadings[timesIndex];
        }

        private int[] ComputeLeadings(int[] persons)
        {
            // 0 <= persons[i] <= persons.length

            var leadings = new int[persons.Length];
            var voteCounts = new int[persons.Length];
            Array.Fill(leadings, 0);

            int maxVoteCount = 0;
            for(int i = 0; i < persons.Length; i++)
            {
                var vote = persons[i];

                voteCounts[vote]++;
                if(voteCounts[vote] >= maxVoteCount)
                {
                    maxVoteCount = voteCounts[vote];
                    leadings[i] = vote;
                }
                else
                {
                    leadings[i] = leadings[i - 1];
                }
            }

            return leadings;
        }
    }
}
