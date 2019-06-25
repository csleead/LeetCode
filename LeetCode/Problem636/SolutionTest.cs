using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem636
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(1, new[] { "0:start:0", "0:end:0" }, new[] { 1 })]
        [InlineData(2, new[] { "0:start:0", "0:end:0", "1:start:1", "1:end:1" }, new[] { 1, 1 })]
        [InlineData(2, new[] { "0:start:0", "1:start:1", "1:end:1", "0:end:2" }, new[] { 2, 1 })]
        [InlineData(3, new[] { "0:start:0", "1:start:1", "2:start:2", "2:end:3", "1:end:4", "0:end:5" }, new[] { 2, 2, 2 })]
        [InlineData(1, new[] { "0:start:0", "0:start:2", "0:end:5", "0:start:6", "0:end:6", "0:end:7" }, new[] { 8 })]
        [InlineData(2, new[] { "0:start:0", "0:start:2", "0:end:5", "1:start:6", "1:end:6", "0:end:7" }, new[] { 7, 1 })]
        public void Test(int n, IList<string> logs, int[] expected)
        {
            new Solution().ExclusiveTime(n, logs)
                .ShouldBeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
