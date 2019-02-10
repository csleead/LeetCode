using FluentAssertions;
using Xunit;

namespace LeetCode.Problem908
{
    public class SolutionTest
    {
        public static TheoryData<int[], int, int> TestCases()
        {
            var data = new TheoryData<int[], int, int>
            {
                { new[] { 1 }, 1, 0 },
                { new[] { 0,10 }, 2, 6 },
                { new[] { 1,3,6 }, 3, 0 },
                { new[] { 0, 10, 18 }, 4, 10 },
                { new[] { 0, 10, 18 }, 3, 12 },
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[] A, int K, int expected)
        {
            var actual = new Solution().SmallestRangeI(A, K);
            actual.Should().Be(expected);
        }
    }
}
