using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC0050
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            else if (n == 1)
                return x;
            else if (n == -1)
                return 1 / x;

            var sqrt = MyPow(x, n / 2);
            return sqrt * sqrt * MyPow(x, n % 2);
        }
    }
}
