using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem540
{
    public class SolutionTest
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[] input, int expected) => new Solution().SingleNonDuplicate(input).Should().Be(expected);

        public static TheoryData<int[], int> TestData()
        {
            var data = new TheoryData<int[], int>
            {
                { new[] { 1 }, 1 },
                { new[] { 1, 1, 2 }, 2 },
                { new[] { 1, 2, 2 }, 1 },
                { new[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }, 2 },
                { new[] { 3, 3, 7, 7, 10, 11, 11 }, 10 }
            };

            return data;
        }
    }
}
