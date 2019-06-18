using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem9
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if(x < 0)
                return false;

            if(x < 10)
                return true;

            int xx = x;
            int y = 0;
            while(xx > 0)
            {
                y = 10 * y + xx % 10;
                xx /= 10;
            }

            return x == y;
        }
    }
}
