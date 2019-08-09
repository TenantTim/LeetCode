using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Utils;

/// <summary>
/// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
/// Given a linked list, remove the n-th node from the end of list and return its head.
/// Sample:
///   (1->2->3->4->5, 2) => 1->2->3->5
/// </summary>

// For counting problem through a LinkedList, a fast/slow iterator pair is efficient

namespace LeetCode.Solutions.LC019
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var fast = head;
            var slow = head;
            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            // Keypoint: Handle the case if we're removing the first node
            if (fast == null)
                return head.next;

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return head;
        }
    }
}
