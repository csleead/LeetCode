using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem278
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(1, 5)]
        [InlineData(2, 5)]
        [InlineData(3, 5)]
        [InlineData(4, 5)]
        [InlineData(5, 5)]
        [InlineData(int.MaxValue, int.MaxValue)]
        public void Test(int firstBadVersion, int n)
        {
            var solution = new Solution
            {
                BadVersion = firstBadVersion
            };

            solution.FirstBadVersion(n).Should().Be(firstBadVersion);
        }
    }
}
