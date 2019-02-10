using FluentAssertions;
using Xunit;

namespace LeetCode.Problem883
{
    public class SolutionTest
    {
        public static TheoryData<int[][], int> TestCases()
        {
            var data = new TheoryData<int[][], int>
            {
                { new[] { new[] { 2 } }, 5 },
                { new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 17 },
                { new[] { new[] { 1, 0 }, new[] { 0, 2 } }, 8 },
                { new[] { new[] { 1,1,1 }, new[] { 1,0,1 }, new[] { 1, 1, 1 } }, 14 },
                { new[] { new[] { 2,2,2 }, new[] { 2,1,2 }, new[] { 2, 2, 2 } }, 21 },
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[][] grid, int expected)
        {
            var actual = new Solution().ProjectionArea(grid);
            actual.Should().Be(expected);
        }
    }
}
