using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem852
{
    public class Solution
    {
        // Given an array that is definitely a mountain, return any i such that
        // A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1].
        public int PeakIndexInMountainArray(int[] A)
        {
            for(int i = 1; i < A.Length - 1; i++)
            {
                if(A[i - 1] < A[i] && A[i] > A[i + 1])
                    return i;
            }

            throw new Exception("never");
        }
    }
}
