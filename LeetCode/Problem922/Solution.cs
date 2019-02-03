using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem922
{
    // Given an array A of non-negative integers, half of the integers in A are odd, and half of the integers are even.
    // Sort the array so that whenever A[i] is odd, i is odd; and whenever A[i] is even, i is even.
    // You may return any answer array that satisfies this condition.
    // - 2 <= A.length <= 20000
    // - A.length % 2 == 0
    // - 0 <= A[i] <= 1000
    public class Solution
    {
        public int[] SortArrayByParityII(int[] A)
        {
            int even = 0, odd = 1;
            while(even < A.Length && odd < A.Length)
            {
                if(A[even] % 2 == 0)
                {
                    even += 2;
                }
                else if(A[odd] % 2 != 0)
                {
                    odd += 2;
                }
                else
                {
                    int temp = A[even];
                    A[even] = A[odd];
                    A[odd] = temp;
                }
            }

            return A;
        }
    }
}
