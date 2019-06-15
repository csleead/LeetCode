using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem547
{
    public class SolutionTest
    {
        public static TheoryData<int[][], int> TestCases()
        {
            return new TheoryData<int[][], int>
            {
                { new[] { new[]{ 1, 0, 0 }, new[]{ 0, 1, 0 }, new[]{ 0, 0, 1 } }, 3 },
                { new[] { new[]{ 1, 1, 0 }, new[]{ 1, 1, 0 }, new[]{ 0, 0, 1 } }, 2 },
                { new[] { new[]{ 1, 0, 0, 1 }, new[]{ 0, 1, 1, 0 }, new[]{ 0, 1, 1, 1 }, new[] { 1, 0, 1, 1 } }, 1 },
            };
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[][] M, int expected)
        {
            new Solution().FindCircleNum(M).Should().Be(expected);
        }
    }
}
