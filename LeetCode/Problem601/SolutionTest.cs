using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem601
{
    public class SolutionTest
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[] flowerbed, int n, bool expected)
        {
            var actual = new Solution().CanPlaceFlowers(flowerbed, n);

            actual.Should().Be(expected);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new[] { 0 }, 1, true };
            yield return new object[] { new[] { 1 }, 1, false };
            yield return new object[] { new[] { 0 }, 2, false };
            yield return new object[] { new[] { 1, 0, 1 }, 1, false };
            yield return new object[] { new[] { 1, 0, 0, 1 }, 1, false };
            yield return new object[] { new[] { 1, 1, 0, 0 }, 1, true };
            yield return new object[] { new[] { 1, 0, 0, 0, 1 }, 1, true };
            yield return new object[] { new[] { 1, 0, 0, 0, 1 }, 2, false };
            yield return new object[] { new[] { 1, 0, 1, 0, 1 }, 1, false };
            yield return new object[] { new[] { 1, 0, 0, 0, 0, 0, 1 }, 2, true };
            yield return new object[] { new[] { 0, 0, 0, 0 }, 2, true };
        }
    }
}
