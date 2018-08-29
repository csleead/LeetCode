using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Xunit.Abstractions;

namespace LeetCode.Problem338
{
    public class SolutionTest
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int n, int[] expected)
        {
            new Solution().CountBits(n).Should().Equal(expected);
        }

        public static TheoryData<int, int[]> TestCases()
        {
            var data = new TheoryData<int, int[]>();
            data.Add(0, new[] { 0 });
            data.Add(1, new[] { 0, 1 });
            data.Add(5, new[] { 0, 1, 1, 2, 1, 2 });
            data.Add(100, new[] { 0, 1, 1, 2, 1, 2, 2, 3, 1, 2, 2, 3, 2, 3, 3, 4, 1, 2, 2, 3, 2, 3, 3, 4, 2, 3, 3, 4, 3, 4, 4, 5, 1, 2, 2, 3, 2, 3, 3, 4, 2, 3, 3, 4, 3, 4, 4, 5, 2, 3, 3, 4, 3, 4, 4, 5, 3, 4, 4, 5, 4, 5, 5, 6, 1, 2, 2, 3, 2, 3, 3, 4, 2, 3, 3, 4, 3, 4, 4, 5, 2, 3, 3, 4, 3, 4, 4, 5, 3, 4, 4, 5, 4, 5, 5, 6, 2, 3, 3, 4, 3 });
            return data;
        }
    }
}
