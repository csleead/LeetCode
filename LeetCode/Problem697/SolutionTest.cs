using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem697
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 2, 3, 1 }, 2)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new[] { 1, 2, 3, 1, 1 }, 5)]
        [InlineData(new[] { 1, 2, 2, 2, 1 }, 3)]
        public void Test(int[] nums, int expected) =>
            new Solution().FindShortestSubArray(nums).Should().Be(expected);
    }
}
