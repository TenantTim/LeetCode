using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// https://leetcode.com/problems/remove-k-digits/
/// Remove k digits from the number so that the new number is the smallest possible
/// Sample:
///   ("1432219", 3) -> "1219"
///   ("10200", 1) -> "200"
/// </summary>

// Basically, we want to remove a number when it is larger than its next one
// Use a stack to track the left comparer

namespace LeetCode.Solutions.LC402
{
    public class Solution
    {
        public string RemoveKdigits(string num, int k)
        {
            if (k == 0)
                return num;

            Stack<char> stk = new Stack<char>();
            char[] cArray = num.ToCharArray();

            for (int i = 0; i < cArray.Length; i++)
            {
                if (stk.Count == 0 || cArray[i] >= stk.Peek())
                {
                    stk.Push(cArray[i]);
                    continue;
                }

                while (stk.Count > 0 && stk.Peek() > cArray[i])
                {
                    stk.Pop();
                    k--;
                    if (k == 0)
                    {
                        return SummarizeResult(stk, cArray, i);
                    }
                }
                // Keypoint: After we've removed some numbers, current pointed char should be pushed
                stk.Push(cArray[i]);
            }

            // Keypoint: After we've walked through the array, we have to try if we can remove enough numbers
            while (k > 0 && stk.Count > 0)
            {
                stk.Pop();
                k--;
            }

            // Keypoint: At this point, the stack can still be non-empty
            return SummarizeResult(stk, cArray, cArray.Length);
        }

        private string SummarizeResult(Stack<char> stk, char[] cArray, int pivot)
        {
            StringBuilder sb = new StringBuilder();

            while (stk.Count > 0)
                sb.Insert(0, stk.Pop());

            for (int i = pivot; i < cArray.Length; i++)
                sb.Append(cArray[i]);

            // Keypoint: We have to remove the heading '0's carefully
            while (sb.Length > 0 && sb[0] == '0')
            {
                sb.Remove(0, 1);
                if (sb.Length == 0)
                    return "0";
            }

            // Keypoint: The sb can be empty here
            return sb.Length > 0 ? sb.ToString() : "0";
        }
    }
}