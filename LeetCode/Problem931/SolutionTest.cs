using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem931
{
    public class SolutionTest
    {
        public static TheoryData<int[][], int> TestCases()
        {
            return new TheoryData<int[][], int>
            {
                { new[]{ new[]{ 1, 2, 3 } } , 1 },
                { new[]{ new[]{ 1, 2, 3 }, new[]{ 4, 5, 6 }, new[]{ 7, 8, 9 } } , 12 },
                { new[]{ new[]{ 1, 2, 3 }, new[]{ 5, 4, 6 }, new[]{ 8, 9, 7 } } , 12 },
            };
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[][] A, int expected)
        {
            new Solution().MinFallingPathSum(A).Should().Be(expected);
        }
    }
}
