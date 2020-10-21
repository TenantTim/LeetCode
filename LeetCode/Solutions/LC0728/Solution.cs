using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC0728
{
    public class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (IsSelfDivide(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private bool IsSelfDivide(int num)
        {
            int originNum = num;
            while (num > 0)
            {
                if (num % 10 == 0 || originNum % (num % 10) != 0)
                {
                    return false;
                }
                num /= 10;
            }
            return true;
        }
    }
}
