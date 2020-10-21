using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC0122
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                result += (prices[i] > prices[i - 1]) ? prices[i] - prices[i - 1] : 0;
            }

            return result;
        }
    }
}
