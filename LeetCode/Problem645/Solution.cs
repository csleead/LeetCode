using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem645
{
    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            int duplicate = FindDuplicate(nums);

            int sumWithoutError = nums.Length * (nums.Length + 1) / 2;
            int numsSum = nums.Sum();

            return new[] { duplicate, sumWithoutError + duplicate - numsSum };
        }

        private int FindDuplicate(int[] nums)
        {
            int i = 0;
            while(true)
            {
                if(nums[i] == i + 1)
                {
                    i++;
                }
                else
                {
                    var pos = nums[i] - 1;
                    if(nums[pos] == nums[i])
                    {
                        return nums[i];
                    }
                    else
                    {
                        int temp = nums[pos];
                        nums[pos] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
        }
    }
}
