using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem807
{
    public class SolutionTest
    {
        [Fact]
        public void Test1()
        {
            var input = new int[][]
            {
                new[]{ 1 }
            };

            var actual = new Solution().MaxIncreaseKeepingSkyline(input);

            actual.Should().Be(0);
        }

        [Fact]
        public void Test2()
        {
            var input = new int[][]
            {
                new[]{ 3, 0, 8, 4 },
                new[]{ 2, 4, 5, 7 },
                new[]{ 9, 2, 6, 3 },
                new[]{ 0, 3, 1, 0 },
            };

            var actual = new Solution().MaxIncreaseKeepingSkyline(input);

            actual.Should().Be(35);
        }

        [Fact]
        public void Test3()
        {
            var input = new int[][]
            {
                new[]{ 8, 0, 6, 4 },
                new[]{ 2, 10, 5, 7 },
                new[]{ 9, 2, 0, 3},
                new[]{ 0, 7, 3, 0 },
            };

            var actual = new Solution().MaxIncreaseKeepingSkyline(input);

            actual.Should().Be(53);
        }
    }
}
