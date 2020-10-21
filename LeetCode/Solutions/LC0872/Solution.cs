using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LeetCode.Utils;

namespace LeetCode.Solutions.LC0872
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
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> L1 = Leaves(root1);
            List<int> L2 = Leaves(root2);

            return L1.SequenceEqual(L2);
        }

        private List<int> Leaves(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            else if (root.left == null && root.right == null)
            {
                return new List<int> { root.val };
            }

            List<int> L1 = Leaves(root.left);
            List<int> L2 = Leaves(root.right);
            return L1.Concat(L2).ToList();
        }
    }
}
