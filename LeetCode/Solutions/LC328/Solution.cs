using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Utils;

namespace LeetCode.Solutions.LC328
{
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode oriHead = head;
            ListNode toInsert = head, beforeDrag = head.next;
            while (beforeDrag != null && beforeDrag.next != null)
            {
                ListNode reserve = toInsert.next;
                toInsert.next = beforeDrag.next;
                beforeDrag.next = beforeDrag.next.next;
                toInsert.next.next = reserve;

                toInsert = toInsert.next;
                beforeDrag = beforeDrag.next;
            }

            return oriHead;
        }
    }
}
