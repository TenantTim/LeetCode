using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC287
{
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[nums[0]];

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }

            fast = 0;
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;
        }
    }
}
