using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem977
{
    public class SolutionTest
    {
        public static TheoryData<int[], int[]> TestCases()
        {
            var data = new TheoryData<int[], int[]>
            {
                { new int[0], new int[0] },
                { new[] { 1 }, new[] { 1 } },
                { new[] { -1 }, new[] { 1 } },
                { new[] { 0 }, new[] { 0 } },
                { new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 } },
                { new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 } },
                { new[] { 1,2,3 }, new[] { 1,4,9 } },
                { new[] { -3,-2,-1 }, new[] { 1,4,9 } },
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[] input, int[] expected)
        {
            var actual = new Solution().SortedSquares(input);

            actual.ShouldBeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}
