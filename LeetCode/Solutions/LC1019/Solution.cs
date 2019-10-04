using System;
using System.Collections.Generic;
using System.Text;

using LeetCode.Utils;

namespace LeetCode.Solutions.LC1019
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
    public class Solution
    {
        public int[] NextLargerNodes(ListNode head)
        {

            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            int[] result = new int[list.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            for (int i = 1; i < result.Length; i++)
            {
                while (stack.Count > 0 && list[stack.Peek()] < list[i])
                {
                    int index = stack.Pop();
                    result[index] = list[i];
                }
                stack.Push(i);
            }

            return result;
        }
    }
}
