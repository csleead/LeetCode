using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem303
{
    public class NumArray
    {
        private int[] _sums;

        public NumArray(int[] nums)
        {
            // For a weird test case that input an empty array
            // and never call SumRange()
            if(nums.Length == 0)
                return;

            _sums = new int[nums.Length];

            _sums[0] = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                _sums[i] = _sums[i - 1] + nums[i];
            }
        }

        public int SumRange(int i, int j)
        {
            return _sums[j] - _sums.ElementAtOrDefault(i - 1);
        }
    }
}
