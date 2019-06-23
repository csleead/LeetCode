using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem841
{
    public class SolutionTest
    {
        public static TheoryData<int[][], bool> TestCases()
        {
            return new TheoryData<int[][], bool>
            {
                { new[] { new int[0] } , true },
                { new[] { new[]{ 1 }, new[]{ 2 }, new[]{ 3 }, new int[0] } , true },
                { new[] { new[]{ 1 }, new[]{ 2 }, new int[0], new int[0] } , false },
                { new[] { new[] { 1 }, new[]{ 1 }, new[]{ 2 }, new[] { 3 } } , false },
                { new[] { new[]{ 1, 3 }, new[]{ 3, 0, 1 }, new[]{ 2 }, new[]{ 0 } } , false },
            };
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[][] rooms, bool expected)
        {
            var list = new List<IList<int>>();
            foreach(var r in rooms)
            {
                list.Add(r.ToList());
            }

            new Solution().CanVisitAllRooms(list).Should().Be(expected);
        }
    }
}
