using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC1006
{
    public class Solution
    {
        public int Clumsy(int N)
        {
            int sum = 0, flag = 1;

            for (int i = N - 3; i > 0; i -= 4)
                sum += i;

            for (int i = N; i > 0; i -= 4)
            {
                int k = i;
                k *= (i > 1 ? i - 1 : 1);
                k /= (i > 2 ? i - 2 : 1);
                k *= flag;
                flag = -1;
                sum += k;
            }

            return sum;
        }
    }
}
