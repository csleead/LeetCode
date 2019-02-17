using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem860
{
    public class SolutionTest
    {
        public static TheoryData<int[], bool> TestCases()
        {
            var data = new TheoryData<int[], bool>
            {
                { new[] { 5,5,5,10,20 }, true },
                { new[] { 5,5,10 }, true },
                { new[] { 10,10 }, false },
                { new[] { 5,5,10,10,20 }, false }
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[] bills, bool expected)
        {
            var actual = new Solution().LemonadeChange(bills);
            actual.Should().Be(expected);
        }
    }
}
