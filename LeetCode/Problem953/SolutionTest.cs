using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem953
{
    public class SolutionTest
    {
        public static TheoryData<string[], string, bool> TestCases()
        {
            return new TheoryData<string[], string, bool>
            {
                { new[] { "abc" }, "abcdefghijklmnopqrstuvwxyz", true },
                { new[] { "abc","abc" }, "abcdefghijklmnopqrstuvwxyz", true },
                { new[] { "abc","abcd" }, "abcdefghijklmnopqrstuvwxyz", true },
                { new[] { "abcd","abc" }, "abcdefghijklmnopqrstuvwxyz", false },
                { new[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz", true },
                { new[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz", false },
            };
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(string[] words, string order, bool expected)
        {
            new Solution().IsAlienSorted(words, order).Should().Be(expected);
        }
    }
}
