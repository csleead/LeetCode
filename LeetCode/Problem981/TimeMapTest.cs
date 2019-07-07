using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem981
{
    public class TimeMapTest
    {
        [Fact]
        public void GetReturnEmptyStringIfNoValueForKey()
        {
            var map = new TimeMap();
            map.Set("key1", "value1", 0);

            map.Get("key2", 0).Should().BeEmpty();
        }

        [Fact]
        public void GetReturnEmptyStringIfNoValueSetBeforeThatTimestamp()
        {
            var map = new TimeMap();
            map.Set("key", "value", 100);

            map.Get("key", 99).Should().BeEmpty();
        }

        [Fact]
        public void GetReturnThatValueIfValueSetBeforeThatTimestamp()
        {
            var map = new TimeMap();
            map.Set("key", "value", 100);

            map.Get("key", 100).Should().Be("value");
            map.Get("key", 101).Should().Be("value");
        }

        [Fact]
        public void GetReturnThatTheValueWithLatestTimestamp()
        {
            var map = new TimeMap();
            map.Set("key", "value1", 1);
            map.Set("key", "value2", 2);
            map.Set("key", "value3", 3);

            map.Get("key", 1).Should().Be("value1");
            map.Get("key", 2).Should().Be("value2");
            map.Get("key", 3).Should().Be("value3");
        }
    }
}
