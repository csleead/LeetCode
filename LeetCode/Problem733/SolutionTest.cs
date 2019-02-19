using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;
using System.Linq;
using Xunit.Sdk;

namespace LeetCode.Problem733
{
    public class SolutionTest
    {
        public static readonly int NewColor = 65535;

        public static TheoryData<int[,], int, int, int[,]> TestCases()
        {
            var data = new TheoryData<int[,], int, int, int[,]>
            {
                { new int[,]{ { 1, 0 }, { 0, 1 } }, 0, 0, new int[,]{ { NewColor, 0 }, { 0, 1 } } },
                { new int[,]{ { 1, 1 }, { 1, 0 } }, 0, 0, new int[,]{ { NewColor, NewColor }, { NewColor, 0 } } },
                { new int[,]{ { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } }, 1, 1, new int[,]{ { 0, NewColor, 0 }, { NewColor, NewColor, NewColor }, { 0, NewColor, 0 } } },
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[,] input, int sr, int sc, int[,] expected)
        {
            var actual = new Solution().FloodFill(input, sr, sc, NewColor);

            AssertEquivalent(actual, expected);
        }

        [Fact]
        public void OldColorCanEqaulsToNewColor()
        {
            var actual = new Solution().FloodFill(new int[,] { { 0, 0, 0 }, { 0, 1, 1 } }, 1, 1, 1);
            AssertEquivalent(actual, new int[,] { { 0, 0, 0 }, { 0, 1, 1 } });
        }

        private void AssertEquivalent(int[,] actual, int[,] expected)
        {
            for(int i = 0; i < actual.GetLength(0); i++)
            {
                for(int j = 0; j < actual.GetLength(1); j++)
                {
                    if(actual[i, j] != expected[i, j])
                    {
                        throw new XunitException($"actual = {Format(actual)}, expected = {Format(expected)}");
                    }
                }
            }
        }

        private string Format(int[,] arr)
        {
            var s = new StringBuilder();
            s.Append("[");
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                s.Append("[");
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    s.Append(arr[i, j] + ",");
                }
                s.Append("],");
            }
            s.Append("]");

            return s.ToString();
        }
    }
}
