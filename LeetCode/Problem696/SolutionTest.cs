using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem696
{
    public class SolutionTest
    {
        [Theory]
        [InlineData("0", 0)]
        [InlineData("01", 1)]
        [InlineData("011", 1)]
        [InlineData("101", 2)]
        [InlineData("1010", 3)]
        [InlineData("1100", 2)]
        [InlineData("00110", 3)]
        public void Test(string input, int expected)
        {
            var actual = new Solution().CountBinarySubstrings(input);
            actual.Should().Be(expected);
        }
    }
}
