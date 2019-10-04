using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC1003
{
    public class Solution
    {
        public bool IsValid(string S)
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < S.Length; i++)
            {
                switch (S[i])
                {
                    case 'a':
                        stack.Push("a");
                        break;
                    case 'b':
                        if (stack.Count == 0 || stack.Peek() != "a")
                        {
                            return false;
                        }
                        stack.Pop();
                        stack.Push("ab");
                        break;
                    case 'c':
                        if (stack.Count == 0 || stack.Peek() != "ab")
                        {
                            return false;
                        }
                        stack.Pop();
                        break;
                    default:
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
