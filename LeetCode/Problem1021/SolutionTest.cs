using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem1021
{
    public class SolutionTest
    {
        [Theory]
        [InlineData("(()())(())", "()()()")]
        [InlineData("(()())(())(()(()))", "()()()()(())")]
        [InlineData("()()", "")]
        public void Test(string input, string expected)
        {
            new Solution().RemoveOuterParentheses(input).Should().Be(expected);
        }
    }
}
