using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC0009
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int target = 0, originalX = x;
            while (x > 0)
            {
                target = target * 10 + x % 10;
                x /= 10;
            }

            return target == originalX;
        }
    }
}
