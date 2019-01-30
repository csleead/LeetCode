using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem977
{
    public class Solution
    {
        public int[] SortedSquares(int[] A)
        {
            var result = new int[A.Length];
            int i = result.Length - 1;

            int low = 0;
            int up = A.Length - 1;
            while(low <= up)
            {
                if(A[low] * A[low] > A[up] * A[up])
                {
                    result[i] = A[low] * A[low];
                    low++;
                }
                else
                {
                    result[i] = A[up] * A[up];
                    up--;
                }
                i--;
            }

            return result;
        }
    }
}
