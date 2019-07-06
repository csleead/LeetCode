using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem707
{
    public class MyLinkedList
    {
        private int _count;
        private Node _dummyHead;
        private Node _dummyTail;

        public MyLinkedList()
        {
            _dummyHead = new Node();
            _dummyTail = new Node();

            _dummyHead.Next = _dummyTail;
            _dummyTail.Previous = _dummyHead;
        }

        public int Get(int index)
        {
            var node = FindNodeByIndex(index);
            return node?.Value ?? -1;
        }

        public void AddAtHead(int val) => AddAtIndex(0, val);

        public void AddAtTail(int val) => AddAtIndex(_count, val);

        public void AddAtIndex(int index, int val)
        {
            if(index > _count)
                return;

            // For stupid non-sense test case:
            // ["MyLinkedList","addAtIndex","get"]
            // [[],[-1,0],[0]]
            // The Get(0) expected to return 0 instead of -1 header
            if(index < 0)
            {
                AddAtHead(val);
                return;
            }

            var next = index == _count ? _dummyTail : FindNodeByIndex(index);
            var prev = next.Previous;

            var newNode = new Node { Value = val };
            newNode.Previous = prev;
            newNode.Next = next;

            prev.Next = next.Previous = newNode;

            _count++;
        }

        public void DeleteAtIndex(int index)
        {
            var node = FindNodeByIndex(index);
            if(node == null)
                return;

            var prev = node.Previous;
            var next = node.Next;

            prev.Next = next;
            next.Previous = prev;

            _count--;
        }

        private Node FindNodeByIndex(int index)
        {
            if(index < 0 || index >= _count)
                return null;

            if(index <= _count / 2)
            {
                var node = _dummyHead.Next;
                for(int i = 0; i < index; i++)
                {
                    node = node.Next;
                }

                return node;
            }
            else
            {
                var node = _dummyTail.Previous;
                for(int i = _count - 1; i > index; i--)
                {
                    node = node.Previous;
                }

                return node;
            }
        }

        private class Node
        {
            public Node Previous { get; set; }
            public Node Next { get; set; }
            public int Value { get; set; }
        }
    }
}
