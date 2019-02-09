using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem700
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    // Given the root node of a binary search tree (BST) and a value.
    // You need to find the node in the BST that the node's value equals the
    // given value. Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.
    public class Solution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            var current = root;
            while(current != null && current.val != val)
            {
                current = (current.val > val) ? current.left : current.right;
            }

            return current;
        }
    }
}
