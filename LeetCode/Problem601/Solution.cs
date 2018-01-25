using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problem601
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            return n <= CalcMaxNumOfFlower(flowerbed);
        }

        private int CalcMaxNumOfFlower(int[] flowerbed)
        {
            int i = 0, sum = 0;
            while(i < flowerbed.Length)
            {
                if(flowerbed[i] == 0 &&
                    flowerbed.ElementAtOrDefault(i - 1) == 0 &&
                    flowerbed.ElementAtOrDefault(i + 1) == 0)
                {
                    sum++;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            return sum;
        }
    }
}
