using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem56
{
    public class SolutionTest
    {
        [Theory, MemberData(nameof(TestDataSource))]
        public void Test(List<Interval> input, List<Interval> expected)
        {
            var actual = new Solution().Merge(input);
            actual.Should().BeEquivalentTo(expected);
        }

        public static IEnumerable<object[]> TestDataSource()
        {
            yield return new object[] // empty
            {
                new List<Interval> { },
                new List<Interval> { }
            };
            yield return new object[] // one interval
            {
                new List<Interval> { new Interval(1, 2) },
                new List<Interval> { new Interval(1, 2) }
            };
            yield return new object[] // overlap
            {
                new List<Interval> { new Interval(1, 3), new Interval(2, 4)},
                new List<Interval> { new Interval(1, 4) }
            };
            yield return new object[] // not overlap
            {
                new List<Interval> { new Interval(1, 2), new Interval(3, 4)},
                new List<Interval> { new Interval(1, 2), new Interval(3, 4) }
            };
            yield return new object[] // just overlap
            {
                new List<Interval> { new Interval(1, 2), new Interval(2, 3)},
                new List<Interval> { new Interval(1, 3) }
            };
            yield return new object[] // first interval span the second one
            {
                new List<Interval> { new Interval(1, 4), new Interval(2, 3)},
                new List<Interval> { new Interval(1, 4) }
            };
            yield return new object[] // three intervals
            {
                new List<Interval> { new Interval(1, 2), new Interval(2, 3), new Interval(3, 4)},
                new List<Interval> { new Interval(1, 4) }
            };
            yield return new object[] // intervals not in order
            {
                new List<Interval> {  new Interval(2, 3), new Interval(1, 2)},
                new List<Interval> { new Interval(1, 3) }
            };
        }
    }
}
