using System;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem849
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new[] { 1, 0 }, 1)]
        [InlineData(new[] { 0, 1 }, 1)]
        [InlineData(new[] { 1, 0, 0 }, 2)]
        [InlineData(new[] { 0, 1, 0 }, 1)]
        [InlineData(new[] { 0, 0, 1 }, 2)]
        [InlineData(new[] { 1, 0, 1 }, 1)]
        [InlineData(new[] { 1, 0, 0, 1, 0, 0, 0, 0 }, 4)]
        [InlineData(new[] { 1, 0, 0, 0, 0, 1, 0, 0 }, 2)]
        [InlineData(new[] { 1, 0, 0, 0, 0, 0, 1, 0 }, 3)]
        [InlineData(new[] { 0, 1, 1, 1 }, 1)]
        public void Test(int[] seats, int expected) =>
            new Solution().MaxDistToClosest(seats).Should().Be(expected);
    }
}
