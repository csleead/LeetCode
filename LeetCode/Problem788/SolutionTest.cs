using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem788
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(10, 4)]
        [InlineData(20, 9)]
        [InlineData(30, 15)]
        [InlineData(40, 15)]
        [InlineData(10000, 2320)]
        public void Test(int N, int expected)
        {
            new Solution().RotatedDigits(N).Should().Be(expected);
        }
    }
}
