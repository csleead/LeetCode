using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem809
{
    public class SolutionTest
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(string[] words, string pattern, string[] expected)
        {
            var actual = new Solution().FindAndReplacePattern(words, pattern);

            actual.Should().BeEquivalentTo(expected);
        }

        public static TheoryData<string[], string, string[]> TestCases()
        {
            var data = new TheoryData<string[], string, string[]>
            {
                { new[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" }, "abb", new[] { "mee", "aqq" } },
                { new[] { "aaa", "bbb", "ccc" }, "zzz", new[] { "aaa", "bbb", "ccc" } },
                { new[] { "ef", "fq", "ao", "at", "lx" }, "ya", new[] { "ef","fq","ao","at","lx" } },
            };

            return data;
        }
    }
}
