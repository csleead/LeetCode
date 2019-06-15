using LeetCode.Problem925;
using System;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem925
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("", "", true)]
        [InlineData("abc", "abc", true)]
        [InlineData("abcd", "aabbccdd", true)]
        [InlineData("aabb", "aaabbb", true)]
        [InlineData("", "a", false)]
        [InlineData("a", "", false)]
        [InlineData("abc", "ab", false)]
        [InlineData("abc", "ac", false)]
        [InlineData("abc", "bc", false)]
        [InlineData("abc", "xabc", false)]
        [InlineData("abc", "axbc", false)]
        [InlineData("abc", "abcx", false)]
        [InlineData("aaabbb", "aabb", false)]
        public void Test(string name, string typed, bool expected)
        {
            new Solution().IsLongPressedName(name, typed).Should().Be(expected);
        }
    }
}
