using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem509
{
    public class Solution
    {
        private int[] fibs = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040 };

        // Fibonacci Number
        // 0 <= N <= 30
        public int Fib(int N)
        {
            return fibs[N];
        }
    }
}
