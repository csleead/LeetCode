using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using FluentAssertions;
using Xunit.Abstractions;

namespace LeetCode.Problem942
{
    public class SolutionTest
    {
        private readonly ITestOutputHelper _output;

        public SolutionTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData("III")]
        [InlineData("IID")]
        [InlineData("IDI")]
        [InlineData("IDD")]
        [InlineData("DID")]
        [InlineData("DDI")]
        [InlineData("DII")]
        [InlineData("DDD")]
        public void Test(string input)
        {
            var result = new Solution().DiStringMatch(input);

            result.Sum().Should().Be(Enumerable.Range(0, input.Length + 1).Sum());

            _output.WriteLine(string.Join(", ", result));
            for(int i = 0; i < input.Length - 1; i++)
            {
                if(input[i] == 'I')
                {
                    result[i].Should().BeLessThan(result[i + 1]);
                }
                else
                {
                    result[i].Should().BeGreaterThan(result[i + 1]);
                }
            }
        }
    }
}
