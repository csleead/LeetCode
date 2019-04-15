using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem448
{
    public class Solution
    {
        // same idea as https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/discuss/160034/O(n)-Swap
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            PutNumbersToCorrectIndex(nums);

            var result = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != i + 1)
                    result.Add(i + 1);
            }

            return result;
        }

        private void PutNumbersToCorrectIndex(int[] nums)
        {
            int i = 0;
            while(i < nums.Length)
            {
                if(nums[i] == i + 1)
                {
                    i++;
                    continue;
                }

                var distIndex = nums[i] - 1;
                if(nums[distIndex] == distIndex + 1)
                {
                    i++;
                    continue;
                }

                Swap(nums, i, distIndex);
            }
        }

        private void Swap(int[] nums, int a, int b)
        {
            var tmp = nums[a];
            nums[a] = nums[b];
            nums[b] = tmp;
        }
    }
}
