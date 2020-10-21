using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// https://leetcode.com/problems/target-sum/submissions/
/// You are given a list of non-negative integers, a1, a2, ..., an, and a target, S. Now you have 2 symbols + and -. For each integer, you should choose one from + and - as its new symbol.
/// Find out how many ways to assign symbols to make sum of integers equal to target S.
/// Input: nums is [1, 1, 1, 1, 1], S is 3. 
/// Output: 5
/// </summary>

// Build a recursion towards (sum - S) / 2 to validate numbers' sum

namespace LeetCode.Solutions.LC0494
{
    public class Solution
    {
        public int FindTargetSumWays(int[] nums, int S)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            if (sum < S || (sum - S) % 2 != 0)
            {
                return 0;
            }

            return FindTargetSum(nums, 0, (sum - S) / 2);
        }

        private int FindTargetSum(int[] nums, int start, int target)
        {
            if (start == nums.Length)
            {
                return target == 0 ? 1 : 0;
            }

            return
                FindTargetSum(nums, start + 1, target - nums[start]) +
                FindTargetSum(nums, start + 1, target);
        }
    }
}