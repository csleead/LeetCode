using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem482
{
    public class SolutionTest
    {
        [Theory]
        [InlineData("5F3Z-2e-9-w", 4, "5F3Z-2E9W")]
        [InlineData("2-5g-3-J", 2, "2-5G-3J")]
        [InlineData("5F3Z-2e-9-w", 6, "5F-3Z2E9W")]
        [InlineData("a-b-c-d", 4, "ABCD")]
        [InlineData("abcd", 1, "A-B-C-D")]
        [InlineData("--abcd--", 1, "A-B-C-D")]
        public void Test(string S, int K, string expected)
        {
            new Solution().LicenseKeyFormatting(S, K).Should().Be(expected);
        }
    }
}
