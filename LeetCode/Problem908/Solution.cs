using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem908
{
    public class Solution
    {
        // Given an array A of integers, for each integer A[i] we may choose any x with -K <= x <= K, and add x to A[i].
        // After this process, we have some array B.
        // Return the smallest possible difference between the maximum value of B and the minimum value of B.
        public int SmallestRangeI(int[] A, int K)
        {
            if(A.Length == 1)
                return 0;

            FindMinAndMax(A, out var min, out var max);
            return Math.Max(0, max - min - 2 * K);
        }

        private void FindMinAndMax(int[] A, out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;
            foreach(var i in A)
            {
                min = Math.Min(min, i);
                max = Math.Max(max, i);
            }
        }
    }
}
