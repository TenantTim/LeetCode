using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Given a list of daily temperatures T, return a list such that, for each day in the input, tells you how many days you would have to wait until a warmer temperature. If there is no future day for which this is possible, put 0 instead.
/// For example, given the list of temperatures T = [73, 74, 75, 71, 69, 72, 76, 73], your output should be[1, 1, 4, 2, 1, 1, 0, 0].
/// </summary>

// Use stack to mark current 'left' temperature

namespace LeetCode.Solutions.LC739
{
    class Solution
    {
        public int[] DailyTemperatures(int[] T)
        {
            int[] result = new int[T.Length];
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            for (int i = 1; i < T.Length; i++)
            {
                if (stack.Count == 0 || T[i] <= T[stack.Peek()])
                {
                    stack.Push(i);
                    continue;
                }

                while (stack.Count != 0 && T[i] > T[stack.Peek()])
                {
                    result[stack.Peek()] = i - stack.Peek();
                    stack.Pop();
                }
                stack.Push(i);
            }

            return result;
        }
    }
}
