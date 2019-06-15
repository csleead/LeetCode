using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Solution1024
{
    public class SolutionTest
    {
        public static TheoryData<int[][], int, int> TestCases()
        {
            return new TheoryData<int[][], int, int>
            {
                { new[] { new[] { 0,1 }, new[] { 1, 2 }  }, 5, -1 },
                { new[] { new[] { 0,1 }, new[] { 1, 2 }  }, 2, 2 },
                { new[] { new[] { 0,1 }, new[] { 0, 2 }  }, 2, 1 },
                { new[] { new[] { 0,1 }, new[] { 1, 2 }, new[] { 2, 3 }  }, 3, 1 },
                { new[] { new[]{0,2}, new[]{4,6}, new[]{8,10}, new[]{1,9}, new[]{1,5}, new[]{5,9} }, 10, 4 },
                { new[] { new[]{ 5, 7 }, new[]{ 1, 8 }, new[]{ 0, 0 }, new[]{ 2, 3 }, new[]{ 4, 5 }, new[]{ 0, 6 }, new[]{ 5, 10 }, new[]{ 7, 10 } }, 5, 1 },
                { new[] { new[]{ 0, 1 }, new[]{ 6, 8 }, new[]{ 0, 2 }, new[]{ 5, 6 }, new[]{ 0, 4 }, new[]{ 0, 3 }, new[]{ 6, 7 }, new[]{ 1, 3 }, new[]{ 4, 7 }, new[]{ 1, 4 }, new[]{ 2, 5 }, new[]{ 2, 6 }, new[]{ 3, 4 }, new[]{ 4, 5 }, new[]{ 5, 7 }, new[]{ 6, 9 } }, 10 , -1 }
            };
        }
    }
}
