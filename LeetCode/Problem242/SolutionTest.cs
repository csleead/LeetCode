using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem242
{
    public class SolutionTest
    {
        [Theory]
        [InlineData("", "", true)]
        [InlineData("a", "a", true)]
        [InlineData("a", "aa", false)]
        [InlineData("a", "b", false)]
        [InlineData("anagram", "nagaram", true)]
        public void Test(string s, string t, bool expected)
        {
            new Solution().IsAnagram(s, t).Should().Be(expected);
        }
    }
}
