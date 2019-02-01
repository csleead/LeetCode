using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem728
{
    // A self-dividing number is a number that is divisible by every digit it contains.
    // For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
    // Also, a self-dividing number is not allowed to contain the digit zero.
    // Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.
    // Input:
    // - The boundaries of each input argument are 1 <= left <= right <= 10000.
    public class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            return Enumerable.Range(left, right - left + 1).Where(IsSelfDividingNumber).ToList();
        }

        private bool IsSelfDividingNumber(int n)
        {
            int temp = n;
            while(temp > 0)
            {
                int lastDigit = temp % 10;
                if(lastDigit == 0 || n % lastDigit != 0)
                {
                    return false;
                }

                temp /= 10;
            }

            return true;
        }
    }
}
