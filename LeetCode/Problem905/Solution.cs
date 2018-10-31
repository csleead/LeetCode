using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem905
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] A)
        {
            var result = new int[A.Length];
            int odd = result.Length - 1;
            int even = 0;
            foreach(var i in A)
            {
                if(i % 2 == 0)
                {
                    result[even] = i;
                    even++;
                }
                else
                {
                    result[odd] = i;
                    odd--;
                }
            }

            return result;
        }
    }
}
