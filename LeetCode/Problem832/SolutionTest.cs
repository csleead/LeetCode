using FluentAssertions;
using Xunit;

namespace LeetCode.Problem832
{
    public class SolutionTest
    {
        public static TheoryData<int[][], int[][]> TestCases()
        {
            var data = new TheoryData<int[][], int[][]>
            {
                // case 1
                {
                    new[]{
                        new[]{1,1,0},
                        new[]{1,0,1},
                        new[]{0,0,0}
                },
                    new[]{
                        new[]{1,0,0},
                        new[]{0,1,0},
                        new[]{1,1,1}}
                },
                // case 2
                {
                    new[]{
                       new[]{1,1,0,0},
                       new[]{1,0,0,1},
                       new[]{0,1,1,1},
                       new[]{1,0,1,0}
                    },
                    new[]{
                       new[]{1,1,0,0},
                       new[]{0,1,1,0},
                       new[]{0,0,0,1},
                       new[]{1,0,1,0}
                    }
                },
                // case 3
                {
                    new[]{
                       new[]{1}
                    },
                    new[]{
                       new[]{0}
                    }
                },
                // case 4
                 {
                    new[]{
                       new[]{1, 0},
                       new[]{0, 1},
                    },
                    new[]{
                       new[]{1, 0},
                       new[]{0, 1},
                    }
                },
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(int[][] input, int[][] expected)
        {
            var actual = new Solution().FlipAndInvertImage(input);

            int n = input.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    actual[i][j].Should().Be(expected[i][j], $"[{i}][{j}] not equals");
                }
            }
        }
    }
}
