using FluentAssertions;
using LeetCode.Problem911;
using System;
using Xunit;

namespace LeetCode.Problem911
{
    public class TopVotedCandidateTests
    {
        [Fact]
        public void Q_StateUnderTest_ExpectedBehavior()
        {
            var persons = new[] { 0, 1, 1, 0, 0, 1, 0 };
            var times = new[] { 0, 5, 10, 15, 20, 25, 30 };

            var topVotedCandidate = new TopVotedCandidate(persons, times);

            var testCases = new[]
            {
                (3, 0),
                (12,1),
                (25,1),
                (15, 0),
                (24,0),
                (8,1)
            };

            foreach(var testCase in testCases)
            {
                topVotedCandidate.Q(testCase.Item1).Should().Be(testCase.Item2);
            }
        }
    }
}
