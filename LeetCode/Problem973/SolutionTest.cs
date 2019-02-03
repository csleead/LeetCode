using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using System.Linq;

namespace LeetCode.Problem973
{
    public class SolutionTest
    {
        public static TheoryData<Point[], int, Point[]> TestCases()
        {
            var data = new TheoryData<Point[], int, Point[]>
            {
                { new[] { new Point(1,1) }, 1, new[] { new Point(1,1) } },
                { new[] { new Point(1, 1), new Point(2, 2) }, 1, new[] { new Point(1, 1) } },
                { new[] { new Point(1, 1), new Point(2, 2) }, 2, new[] { new Point(1, 1), new Point(2, 2) } },
                {
                    new[] { new Point(1, 1), new Point(2, 2),  new Point(3, 3), new Point(4, 4),  new Point(5, 5), new Point(6, 6), },
                    3,
                    new[] { new Point(1, 1), new Point(2, 2), new Point(3, 3) }
                },
                { new[] { new Point(1, 1) }, 999, new[] { new Point(1, 1) } },
                {
                    new[] { new Point(5, 5), new Point(4, 4), new Point(3, 3), new Point(2, 2),  new Point(1, 1), },
                    2,
                    new[] { new Point(1, 1), new Point(2, 2) }
                },
            };

            return data;
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(Point[] input, int k, Point[] expected)
        {
            var actualArray = new Solution().KClosest(input.Select(arr => arr.ToArray()).ToArray(), k);

            var actualPoints = actualArray.Select(arr => new Point(arr)).ToArray();
            actualPoints.Should().BeEquivalentTo(expected);
        }

        public class Point : IEquatable<Point>
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public Point(int[] arr)
            {
                X = arr[0];
                Y = arr[1];
            }

            public int[] ToArray() => new[] { X, Y };

            public override bool Equals(object obj) => Equals(obj as Point);

            public bool Equals(Point other)
            {
                return other != null &&
                       X == other.X &&
                       Y == other.Y;
            }

            public override int GetHashCode()
            {
                var hashCode = 1861411795;
                hashCode = hashCode * -1521134295 + X.GetHashCode();
                hashCode = hashCode * -1521134295 + Y.GetHashCode();
                return hashCode;
            }

            public override string ToString() => $"({X},{Y}), Dist = {X * X + Y * Y}";
        }
    }
}
