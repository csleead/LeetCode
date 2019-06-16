using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem742
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(new int[] { }, -1)]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 0, 1, -1 }, 0)]
        [InlineData(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
        [InlineData(new[] { -1, -1, -1, 0, 1, 1 }, 0)]
        public void Test(int[] nums, int expected) =>
            new Solution().PivotIndex(nums).Should().Be(expected);
    }
}
