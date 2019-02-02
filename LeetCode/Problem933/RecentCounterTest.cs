using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem933
{
    public class RecentCounterTest
    {
        private readonly RecentCounter _counter = new RecentCounter();

        [Fact]
        public void ShouldIncludeTheLastPing()
        {
            var count = _counter.Ping(1);
            count.Should().Be(1);
        }

        [Fact]
        public void ShouldIncludeCountWithin3000Ms()
        {
            _counter.Ping(1);
            var count = _counter.Ping(3001);
            count.Should().Be(2);
        }

        [Fact]
        public void ShouldNotIncludeCountBeforeMoreThan3000Ms()
        {
            _counter.Ping(1);
            var count = _counter.Ping(3002);
            count.Should().Be(1);
        }
    }
}
