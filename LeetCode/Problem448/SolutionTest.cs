using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem448
{
    public class SolutionTest
    {
        public static TheoryData<int[], HashSet<int>> TestData()
        {
            var data = new TheoryData<int[], HashSet<int>>
            {
                { new[] { 2,2,3 }, new HashSet<int> { 1 } },
                { new[] { 2,3,2 }, new HashSet<int> { 1 } },
                { new[] { 3,2,2 }, new HashSet<int> { 1 } },
                { new[] { 1,2,2 }, new HashSet<int> { 3 } },
                { new[] { 4, 3, 2, 7, 8, 2, 3, 1 } ,new HashSet<int>{5,6} }
            };
            return data;
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int[] nums, HashSet<int> expected)
        {
            var actual = new HashSet<int>(new Solution().FindDisappearedNumbers(nums));
            actual.ShouldBeEquivalentTo(expected);
        }
    }
}
