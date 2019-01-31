using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem961
{
    public class SolutionTest
    {
        public static TheoryData<int[], int> TestCases()
        {
            var data = new TheoryData<int[], int>
            {
                { new[] { 2, 1, 3, 2 }, 2 },
                { new[] { 1, 2, 3, 3 }, 3 },
                { new[] { 2,1,2,5,3,2 }, 2 },
                { new[] { 5,1,5,2,5,3,5,4 }, 5 },
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[] input, int expected)
        {
            var actual = new Solution().RepeatedNTimes(input);

            actual.Should().Be(expected);
        }
    }
}
