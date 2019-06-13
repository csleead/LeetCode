using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem1005
{
    public class SolutionTest
    {
        public static TheoryData<int[], int, int> TestCases()
        {
            return new TheoryData<int[], int, int>
            {
                { new[] { 1 }, 1, -1  },
                { new[] { 1 }, 2, 1  },
                { new[] { 1 }, 3, -1  },
                { new[] { 1,1 }, 1, 0  },
                { new[] { 2,-3,-1,5,-4 }, 2, 13 }
            };
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[] A, int K, int expected)
        {
            new Solution().LargestSumAfterKNegations(A, K).Should().Be(expected);
        }
    }
}
