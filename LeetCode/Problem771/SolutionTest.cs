using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem771
{
    public class SolutionTest
    {
        [Theory]
        [InlineData("", "Whatever", 0)]
        [InlineData("aA", "aAAbbbb", 3)]
        [InlineData("z", "ZZ", 0)]
        [InlineData("A", "AAAAAA", 6)]
        public void Test(string J, string S, int expected)
        {
            new Solution().NumJewelsInStones(J, S).Should().Be(expected);
        }
    }
}
