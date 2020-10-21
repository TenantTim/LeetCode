using System;
using System.Collections.Generic;
using System.Text;

using LeetCode.Utils;

namespace LeetCode.Solutions.LC0226
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode node = root.left;
            root.left = root.right;
            root.right = node;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
