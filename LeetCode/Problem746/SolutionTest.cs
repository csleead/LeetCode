using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem746
{
    public class SolutionTest
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[] cost, int expected)
        {
            var actual = new Solution().MinCostClimbingStairs(cost);
            actual.Should().Be(expected);
        }

        public static TheoryData<int[], int> TestCases()
        {
            return new TheoryData<int[], int>
            {
                { new[]{ 10, 15, 20 }, 15 },
                { new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6 }
            };
        }
    }
}
