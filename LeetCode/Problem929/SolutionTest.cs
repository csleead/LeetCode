using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetCode.Problem929
{
    public class SolutionTest
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void Test(string[] emails, int expected)
        {
            new Solution().NumUniqueEmails(emails).Should().Be(expected);
        }

        public static TheoryData<string[], int> TestCases()
        {
            var data = new TheoryData<string[], int>
            {
                { new string[0], 0 },
                { new [] { "abc@def.com" }, 1 },
                { new[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" }, 2 }
            };
            return data;
        }
    }
}
