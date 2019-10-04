using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC962
{
    public class Solution
    {
        public int MaxWidthRamp(int[] A)
        {
            if (A.Length < 2)
            {
                return 0;
            }

            Stack<int> stack = new Stack<int>();
            int curMin = A[0];
            stack.Push(0);
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < curMin)
                {
                    curMin = A[i];
                    stack.Push(i);
                }
            }

            int longest = -1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && A[i] >= A[stack.Peek()])
                {
                    int index = stack.Peek();
                    longest = longest < i - index ? i - index : longest;
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    return longest;
                }
            }

            return longest;
        }
    }
}
