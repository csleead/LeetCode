using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem944
{
    public class SolutionTest
    {
        public static TheoryData<string[], int> TestCases()
        {
            var data = new TheoryData<string[], int>
            {
                { new[] { "cba","daf","ghi" }, 1 },
                { new[] { "a","b" }, 0 },
                { new[] { "zyx","wvu","tsr" }, 3 },
                { new[] { "ab" }, 0 },
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(string[] input, int expected)
        {
            var actual = new Solution().MinDeletionSize(input);

            actual.Should().Be(expected);
        }
    }
}
