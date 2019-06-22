using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem876
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var fast = head;
            var slow = head;

            while(fast.next != null)
            {
                if(fast.next != null)
                    fast = fast.next;

                if(fast.next != null)
                    fast = fast.next;

                slow = slow.next;
            }

            return slow;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}
