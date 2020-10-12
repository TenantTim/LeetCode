using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC1304
{
    public class Solution
    {
        public int[] SumZero(int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = i - n / 2;
            }

            if (n % 2 == 0)
            {
                result[n - 1] += n / 2;
            }

            return result;
        }
    }
}
