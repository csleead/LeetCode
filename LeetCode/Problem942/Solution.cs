using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem942
{
    // Given a string S that only contains "I" (increase) or "D" (decrease), let N = S.length.
    // Return any permutation A of [0, 1, ..., N] such that for all i = 0, ..., N-1:
    // - If S[i] == "I", then A[i] < A[i+1]
    // If S[i] == "D", then A[i] > A[i+1]
    // Inputs:
    // - 1 <= S.length <= 10000
    // - S only contains characters "I" or "D"
    public class Solution
    {
        public int[] DiStringMatch(string S)
        {
            int dCount = 0;
            foreach(var c in S)
            {
                if(c == 'D')
                {
                    dCount++;
                }
            }

            var arr = new int[S.Length + 1];
            arr[0] = dCount;
            int min = dCount, max = dCount;
            for(int i = 1; i < arr.Length; i++)
            {
                if(S[i - 1] == 'I')
                {
                    arr[i] = max + 1;
                    max++;
                }
                else
                {
                    arr[i] = min - 1;
                    min--;
                }
            }

            return arr;
        }
    }
}
