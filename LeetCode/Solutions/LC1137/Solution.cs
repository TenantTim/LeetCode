using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC1137
{
    public class Solution
    {
        public int Tribonacci(int n)
        {
            int[] tribonacciResults = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                tribonacciResults[i] = i <= 2 ? (i + 1) / 2 : tribonacciResults[i - 3] + tribonacciResults[i - 2] + tribonacciResults[i - 1];
            }

            return tribonacciResults[n];
        }
    }
}
