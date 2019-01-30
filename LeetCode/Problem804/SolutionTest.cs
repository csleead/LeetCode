using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem804
{
    public class SolutionTest
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(string[] words, int expected)
        {
            new Solution().UniqueMorseRepresentations(words).Should().Be(expected);
        }

        public static TheoryData<string[], int> TestCases()
        {
            var data = new TheoryData<string[], int>
            {
                { new string[0], 0 },
                { new [] { "gin", "zen", "gig", "msg" }, 2 },
            };
            return data;
        }
    }
}
