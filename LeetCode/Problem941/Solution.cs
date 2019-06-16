using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem941
{
    public class Solution
    {
        public bool ValidMountainArray(int[] A)
        {
            if(A.Length < 3)
                return false;

            var possiblePeak = ClimbUntilDescend(A);
            if(possiblePeak == 0 || possiblePeak == A.Length - 1)
            {
                return false;
            }

            return IsKeepDescending(A, possiblePeak);
        }

        private int ClimbUntilDescend(int[] A)
        {
            int i = 0;
            while(i + 1 < A.Length && A[i] < A[i + 1])
                i++;

            return i;
        }

        private bool IsKeepDescending(int[] A, int possiblePeak)
        {
            int i = possiblePeak + 1;
            while(i < A.Length)
            {
                if(A[i - 1] <= A[i])
                    return false;

                i++;
            }

            return true;
        }
    }
}
