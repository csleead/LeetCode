using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem961
{
    public class Solution
    {
        // In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.
        // Return the element repeated N times.
        // Input assumptions:
        // - 4 <= A.length <= 10000
        // - 0 <= A[i] < 10000
        // - A.length is even
        public int RepeatedNTimes(int[] A)
        {
            // Since half of the array elements are the repeated number.
            // if A.Length != 4, we can always find two adjacent repeated
            // elements seperated by at most 2
            for(int i = 0; i < A.Length - 2; i++)
            {
                if(A[i] == A[i + 1] || A[i] == A[i + 2])
                {
                    return A[i];
                }
            }

            // Special cases:
            // [x,a,b,x], "x" is seperated by 3
            // [a,b,x,x] or [x,a,b,c,x,x], the above loop only reach "b" or "c"
            // The last element is always the repeated one no matther which case it is
            return A[A.Length - 1];
        }
    }
}
