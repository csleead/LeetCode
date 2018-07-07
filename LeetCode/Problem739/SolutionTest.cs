using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problem739
{
    public class SolutionTest
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[] input, int[] expected)
        {
            Assert.Equal(expected, new Solution().DailyTemperatures(input));
        }

        public static TheoryData<int[], int[]> TestCases()
        {
            var testCases = new TheoryData<int[], int[]>
            {
                { new int[0], new int[0] },
                { new[] { 50 }, new[] { 0 } },
                { new[] { 50, 50 }, new[] { 0, 0 } },
                { new[] { 50, 51 }, new[] { 1, 0 } },
                { new[] { 50, 49, 51 }, new[] { 2, 1, 0 } },
                { new[] { 50, 52, 51 }, new[] { 1, 0, 0 } },
                { new[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new[] { 1, 1, 4, 2, 1, 1, 0, 0 } }
            };

            return testCases;
        }
    }
}
