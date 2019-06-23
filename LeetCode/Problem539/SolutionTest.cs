using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem539
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(new[] { "00:00", "00:00" }, 0)]
        [InlineData(new[] { "00:00", "11:59" }, 12 * 60 - 1)]
        [InlineData(new[] { "00:00", "12:01" }, 12 * 60 - 1)]
        public void Test(string[] timePoints, int expected)
            => new Solution().FindMinDifference(timePoints).Should().Be(expected);
    }
}
