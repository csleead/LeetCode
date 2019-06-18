using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem997
{
    public class Solution
    {
        public int FindJudge(int N, int[][] trust)
        {
            int[] trustCount = new int[N];
            Array.Fill(trustCount, 0);

            int[] trustedCount = new int[N];
            Array.Fill(trustedCount, 0);

            foreach(var t in trust)
            {
                trustCount[t[0] - 1]++;
                trustedCount[t[1] - 1]++;
            }

            int maybeJudge = -1;
            for(int i = 0; i < N; i++)
            {
                if(trustCount[i] == 0 && trustedCount[i] == N - 1)
                {
                    if(maybeJudge == -1)
                    {
                        maybeJudge = i + 1;
                    }
                    else
                    {
                        // two people satisfying criteria of judge
                        return -1;
                    }
                }
            }

            return maybeJudge;
        }
    }
}
