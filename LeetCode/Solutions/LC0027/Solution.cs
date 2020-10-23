using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC0027
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }

            return count;
        }
    }
}
