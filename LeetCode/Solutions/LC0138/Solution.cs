using System.Collections.Generic;
using LeetCode.Utils;

/// <summary>
/// https://leetcode.com/problems/copy-list-with-random-pointer/
/// A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null
/// Return a deep copy of the list
/// </summary>

// Iterate twice, record the mapping between old node and new node in the first iteration
// Then direct the correct random pointer in the 2nd iteration

namespace LeetCode.Solutions.LC0138
{
    public class Solution
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            if (head == null)
                return null;

            Dictionary<RandomListNode, RandomListNode> m_dupMap = new Dictionary<RandomListNode, RandomListNode>();

            RandomListNode oldIter = head, oldHead = head;
            RandomListNode newIter = null, newHead = new RandomListNode(head.label);

            while (oldIter != null)
            {
                if (newIter == null)
                    newIter = newHead;

                m_dupMap[oldIter] = newIter;

                if (oldIter.next != null)
                {
                    newIter.next = new RandomListNode(oldIter.next.label);
                    newIter = newIter.next;
                }

                oldIter = oldIter.next;
            }

            oldIter = oldHead;
            newIter = newHead;

            while (oldIter != null)
            {
                if (oldIter.random == null)
                    newIter.random = null;
                else
                    newIter.random = m_dupMap[oldIter.random];

                oldIter = oldIter.next;
                newIter = newIter.next;
            }

            return newHead;
        }
    }
}
