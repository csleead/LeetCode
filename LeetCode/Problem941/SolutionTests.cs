using System;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem941
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[0], false)]
        [InlineData(new[] { 0, 1, 2 }, false)]
        [InlineData(new[] { 2, 1, 0 }, false)]
        [InlineData(new[] { 0, 1, 1 }, false)]
        [InlineData(new[] { 1, 1, 0 }, false)]
        [InlineData(new[] { 0, 1, 2, 1, 0 }, true)]
        public void Test(int[] A, bool expected) =>
            new Solution().ValidMountainArray(A).Should().Be(expected);
    }
}
