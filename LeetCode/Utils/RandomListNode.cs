using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Utils
{
    public class RandomListNode : ListNode
    {
        public int label { get { return val; } }

        public new RandomListNode next { get; set; }

        public RandomListNode random { get; set; }

        public RandomListNode(int x) :
           base(x)
        {
        }
    }
}
