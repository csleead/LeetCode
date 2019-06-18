using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using System.Linq;

namespace LeetCode.Problem9
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(121)]
        [InlineData(123454321)]
        public void Test(int x)
        {
            var expected = x.ToString() == new string(x.ToString().ToCharArray().Reverse().ToArray());
            new Solution().IsPalindrome(x).Should().Be(expected);
        }
    }
}
