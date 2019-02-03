using FluentAssertions;
using Xunit;

namespace LeetCode.Problem985
{
    public class SolutionTest
    {
        public static TheoryData<int[], int[][], int[]> TestCases()
        {
            var data = new TheoryData<int[], int[][], int[]>
            {
                { new int[0], new int[0][], new int[0] },
                { new[] { 1 }, new[] { new[] { 0,0 } } , new[] { 0 } },
                { new[] { 1 }, new[] { new[] { 1,0 } } , new[] { 2 } },
                { new[] { 2 }, new[] { new[] { 0,0 } } , new[] { 2 } },
                { new[] { 2 }, new[] { new[] { 1,0 } } , new[] { 0 } },
                { new[] { -2 }, new[] { new[] { 0,0 } } , new[] { -2 } },
                { new[] { 1,2,3,4,5 }, new[] { new[] { 1,0 } } , new[] { 8 } },
                { new[] { 1,2,3,4,5 }, new[] { new[] { 1,1 } } , new[] { 4 } },
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[] arr, int[][] queries, int[] expected)
        {
            var actual = new Solution().SumEvenAfterQueries(arr, queries);

            actual.ShouldBeEquivalentTo(expected, opt => opt.WithStrictOrdering());
        }
    }
}
