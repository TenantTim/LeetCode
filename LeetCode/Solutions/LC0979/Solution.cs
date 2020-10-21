using System;
using System.Collections.Generic;
using System.Text;

using LeetCode.Utils;

namespace LeetCode.Solutions.LC0979
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

        private int sum = 0;

        public int DistributeCoins(TreeNode root)
        {
            sum = 0;
            CalcDiff(root);
            return sum;
        }

        private int CalcDiff(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftDiff = CalcDiff(root.left), rightDiff = CalcDiff(root.right);
            sum += Math.Abs(root.val - 1 + leftDiff + rightDiff);
            return root.val - 1 + leftDiff + rightDiff;
        }
    }
}
