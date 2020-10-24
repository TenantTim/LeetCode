using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Utils;

namespace LeetCode.Solutions.LC0110
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return (GetHeight(root) != -1);
        }

        private int GetHeight(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = GetHeight(root.left);
            if (leftHeight == -1)
                return -1;

            int rightHeight = GetHeight(root.right);
            if (rightHeight == -1 || Math.Abs(leftHeight - rightHeight) > 1)
                return -1;

            else return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
