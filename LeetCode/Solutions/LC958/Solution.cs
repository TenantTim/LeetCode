using System;
using System.Collections.Generic;
using System.Text;

using LeetCode.Utils;

namespace LeetCode.Solutions.LC958
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
        public bool IsCompleteTree(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            bool sawNull = false;
            while (queue.Count > 0)
            {
                TreeNode cur = queue.Dequeue();
                if (cur != null)
                {
                    if (sawNull || (cur.right != null && cur.left == null))
                    {
                        return false;
                    }

                    queue.Enqueue(cur.left);
                    queue.Enqueue(cur.right);
                }
                else
                {
                    sawNull = true;
                }
            }

            return true;
        }
    }
}
