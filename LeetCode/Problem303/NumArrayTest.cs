using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem303
{
    public class NumArrayTest
    {
        [Fact]
        public void AllowEmptyArray()
        {
            Action action = () => new NumArray(new int[0]);
            action.ShouldNotThrow();
        }

        [Theory]
        [InlineData(0, 0, 1)]
        [InlineData(9999, 9999, 1)]
        [InlineData(0, 9999, 10000)]
        [InlineData(1000, 2000, 1001)]
        [InlineData(2000, 4000, 2001)]
        public void Test(int i, int j, int expected)
        {
            var arr = new NumArray(Enumerable.Repeat(1, 10000).ToArray());

            arr.SumRange(i, j).Should().Be(expected);
        }
    }
}
