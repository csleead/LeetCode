using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem540
{
    public class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            int low = 0, up = nums.Length - 1;

            while(true)
            {
                if(low == up)
                    return nums[low];

                int mid = (low + up) / 2;
                if(nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                    return nums[mid];

                if(mid % 2 == 0)
                {
                    if(nums[mid] == nums[mid + 1])
                        low = mid + 2;
                    else
                        up = mid;
                }
                else
                {
                    if(nums[mid] == nums[mid - 1])
                        low = mid + 1;
                    else
                        up = mid - 1;
                }
            }
        }
    }
}
