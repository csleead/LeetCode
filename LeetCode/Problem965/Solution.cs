using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem965
{
    public class Solution
    {
        // A binary tree is univalued if every node in the tree has the same value.
        // Return true if and only if the given tree is univalued.
        // Input:
        // The number of nodes in the given tree will be in the range [1, 100].
        public bool IsUnivalTree(TreeNode root)
        {
            if(root.left != null && root.left.val != root.val)
            {
                return false;
            }

            if(root.right != null && root.right.val != root.val)
            {
                return false;
            }

            return (root.left == null || IsUnivalTree(root.left)) && (root.right == null || IsUnivalTree(root.right));
        }
    }

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
}
