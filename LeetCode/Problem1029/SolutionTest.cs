using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem1029
{
    public class SolutionTest
    {
        public static TheoryData<int[][], int> TestCases()
        {
            return new TheoryData<int[][], int>
            {
                { new[]{ new[]{ 10, 20 }, new[] { 10, 20 } }, 30 },
                { new[]{ new[]{ 10, 20 }, new[]{ 30, 200 }, new[]{ 400, 50 }, new[]{ 30, 20 } }, 110 },
                { new[]{ new[]{ 100, 150 }, new[] { 0 , 100 } }, 150 },
            };
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[][] costs, int expected)
        {
            new Solution().TwoCitySchedCost(costs).Should().Be(expected);
        }
    }
}
