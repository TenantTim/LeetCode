using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC0258
{
    public class Solution
    {
        public int AddDigits(int num)
        {
            return num == 0 ? 0 : (num % 9 != 0 ? num % 9 : 9);
        }
    }
}
