using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// https://leetcode.com/problems/valid-parentheses/
/// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// Sample:
///   "()" => true
///   “()[]{}” => true
///   "([)]" => false
/// </summary>

// A stack is needed to solve pair matching problem through a string

namespace LeetCode.Solutions.LC0020
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            char[] cArray = s.ToCharArray();
            Stack<char> parentheses = new Stack<char>();
            foreach (char c in cArray)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    parentheses.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (parentheses.Count == 0)
                        return false;
                    char finding = c == ')' ? '(' : (c == ']' ? '[' : '{');
                    if (parentheses.Peek() != finding)
                        return false;
                    parentheses.Pop();
                }
            }

            // Keypoint: It possible that when all charaters were traversed, the stack still has something left
            return parentheses.Count == 0;
        }
    }
}
