using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem876
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 3)]
        [InlineData(6, 4)]
        public void Test(int n, int expected)
        {
            var list = CreateLinkedList(n);
            new Solution().MiddleNode(list).val.Should().Be(expected);
        }

        private ListNode CreateLinkedList(int n)
        {
            var root = new ListNode(1);

            var head = root;
            int i = 2;
            while(i <= n)
            {
                head.next = new ListNode(i);
                head = head.next;

                i++;
            }

            return root;
        }
    }
}
