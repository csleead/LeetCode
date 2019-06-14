using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem645
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(new[] { 1, 1 }, 1, 2)]
        [InlineData(new[] { 1, 3, 4, 3 }, 3, 2)]
        [InlineData(new[] { 3, 1, 4, 3 }, 3, 2)]
        public void Test(int[] array, int duplicateNumber, int missingNumber)
        {
            var result = new Solution().FindErrorNums(array);

            result.Should().HaveCount(2);
            result[0].Should().Be(duplicateNumber);
            result[1].Should().Be(missingNumber);
        }
    }
}
