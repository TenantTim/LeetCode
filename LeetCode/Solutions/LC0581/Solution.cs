using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Given an integer array, you need to find one continuous subarray that if you only sort this subarray in ascending order, then the whole array will be sorted in ascending order, too.
/// You need to find the shortest such subarray and output its length.
/// 
/// Input: [2, 6, 4, 8, 10, 9, 15]
/// Output: 5
/// Explanation: You need to sort [6, 4, 8, 10, 9] in ascending order to make the whole array sorted in ascending order.
/// </summary>

// Tricky solution. Iterate left to right and then right to left, mark max number seen and min number seen to calculate.

namespace LeetCode.Solutions.LC0581
{
    public class Solution
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return 0;
            }

            int maxSeen = nums[0], left = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                maxSeen = Math.Max(maxSeen, nums[i]);
                if (maxSeen > nums[i])
                {
                    left = i;
                }
            }

            int minSeen = nums[nums.Length - 1], right = nums.Length;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                minSeen = Math.Min(minSeen, nums[i]);
                if (minSeen < nums[i])
                {
                    right = i;
                }
            }

            return (left == -1 && right == nums.Length) ? 0 : left - right + 1;
        }
    }
}
