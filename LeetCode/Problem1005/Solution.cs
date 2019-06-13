using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem1005
{
    public class Solution
    {
        public int LargestSumAfterKNegations(int[] A, int K)
        {
            Array.Sort(A);

            var negCount = FindNegativeCount(A);

            if(negCount >= K)
            {
                int result = 0;
                for(int i = 0; i < A.Length; i++)
                {
                    result += (i < K) ? -1 * A[i] : A[i];
                }

                return result;
            }
            else
            {
                int absSum = A.Sum(i => Math.Abs(i));
                if((K - negCount) % 2 == 0)
                {
                    return absSum;
                }
                else
                {
                    int minAbs = A.Min(i => Math.Abs(i));
                    return absSum - 2 * minAbs;
                }
            }
        }

        private int FindNegativeCount(int[] sortedArray)
        {
            int count = 0;
            foreach(var i in sortedArray)
            {
                if(i < 0)
                    count++;
                else
                    break;
            }
            return count;
        }
    }
}
