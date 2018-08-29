using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem338
{
    public class Solution
    {
        public int[] CountBits(int num)
        {
            var result = new int[num + 1];
            result[0] = 0;
            if (num >= 1)
                result[1] = 1;

            int offset = 1;
            for (int i = 2; i <= num; i++)
            {
                if (IsPowerOfTwo(i))
                    offset *= 2;
                result[i] = result[i - offset] + 1;
            }
            return result;
        }

        private bool IsPowerOfTwo(int x) => (x & (x - 1)) == 0;
    }
}
