using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace LeetCode.Problem707
{
    public class MyLinkedListTest
    {
        [Fact]
        public void GetReturnsMinusOneForInvalidIndex()
        {
            var list = new MyLinkedList();
            list.AddAtTail(100);
            list.AddAtTail(200);

            list.Get(-1).Should().Be(-1);
            list.Get(2).Should().Be(-1);
        }

        [Fact]
        public void AddAtTailWorksProperly()
        {
            var list = new MyLinkedList();

            list.AddAtTail(100);
            list.Get(0).Should().Be(100);

            list.AddAtTail(200);
            list.Get(1).Should().Be(200);
        }

        [Fact]
        public void AddAtHeadWorksProperly()
        {
            var list = new MyLinkedList();

            list.AddAtHead(100);
            list.Get(0).Should().Be(100);

            list.AddAtHead(200);
            list.Get(0).Should().Be(200);
        }

        [Fact]
        public void AddAtIndexWorksProperlyIfIndexIsValid()
        {
            var list = new MyLinkedList();

            list.AddAtIndex(0, 200);
            list.Get(0).Should().Be(200);

            list.AddAtIndex(0, 100);
            list.Get(0).Should().Be(100);
            list.Get(1).Should().Be(200);

            list.AddAtIndex(1, 150);
            list.Get(0).Should().Be(100);
            list.Get(1).Should().Be(150);
            list.Get(2).Should().Be(200);
        }

        [Fact]
        public void AddAtIndexDoNothingIfIndexIsGreaterThanLength()
        {
            var list = new MyLinkedList();

            list.AddAtIndex(1, 200);
            list.Get(0).Should().Be(-1);
        }

        [Fact]
        public void AddAtIndexAddToHeadIfIndexIsNegative()
        {
            var list = new MyLinkedList();

            list.AddAtIndex(-1, 100);
            list.Get(0).Should().Be(100);
        }

        [Fact]
        public void DeleteAtIndexWorksProperlyIfIndexIsValid()
        {
            var list = new MyLinkedList();
            list.AddAtTail(100);
            list.AddAtTail(200);
            list.AddAtTail(300);
            list.AddAtTail(400);

            list.DeleteAtIndex(0);
            list.Get(0).Should().Be(200); // [200,300,400]

            list.DeleteAtIndex(1);
            list.Get(1).Should().Be(400); // [200,400]

            list.DeleteAtIndex(1);
            list.Get(1).Should().Be(-1); // [200]

            list.DeleteAtIndex(0);
            list.Get(0).Should().Be(-1); // []
        }

        [Fact]
        public void DeleteAtIndexDoNothingIfIndexIsInvalid()
        {
            var list = new MyLinkedList();
            list.AddAtTail(100);

            list.DeleteAtIndex(-1);
            list.DeleteAtIndex(1);

            list.Get(0).Should().Be(100);
        }
    }
}
