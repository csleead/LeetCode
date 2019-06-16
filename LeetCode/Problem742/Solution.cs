using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem742
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            if(nums.Length == 0)
                return -1;

            int leftSum = nums[0];
            int rightSum = nums.Sum();

            if(leftSum == rightSum)
                return 0;

            for(int i = 1; i < nums.Length; i++)
            {
                leftSum += nums[i];
                rightSum -= nums[i - 1];

                if(leftSum == rightSum)
                    return i;
            }

            return -1;
        }
    }
}
