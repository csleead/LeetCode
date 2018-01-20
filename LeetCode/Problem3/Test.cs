using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem3
{
    public class SolutionTest
    {
        [Theory]
        [InlineData("", 0, "")]
        [InlineData("abcabcbb", 3, "abc")]
        [InlineData("bbbbb", 1, "b")]
        [InlineData("pwwkew", 3, "wke")]
        [InlineData("tmmzuxt", 5, "mzuxt")]
        public void Test(string input, int expected, string possibleSubstring)
        {
            var actual = new Solution().LengthOfLongestSubstring(input);

            actual.Should().Be(expected, $"'{input}' --> '{possibleSubstring}'");
        }
    }
}
