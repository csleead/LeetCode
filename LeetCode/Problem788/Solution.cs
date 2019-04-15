using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem788
{
    public class Solution
    {
        public int RotatedDigits(int N)
        {
            var result = 0;
            for(int i = 1; i <= N; i++)
            {
                var num = i;
                bool canRotate = true;
                bool hasGoodDigit = false;
                while(num > 0)
                {
                    var lastDigit = num % 10;

                    // 3, 4 and 7 cannot be rotated
                    if(lastDigit == 3 || lastDigit == 4 || lastDigit == 7)
                    {
                        canRotate = false;
                        break;
                    }

                    if(lastDigit == 2 || lastDigit == 5 || lastDigit == 6 || lastDigit == 9)
                    {
                        hasGoodDigit = true;
                    }

                    num /= 10;
                }

                if(canRotate && hasGoodDigit)
                    result++;
            }

            return result;
        }
    }
}
