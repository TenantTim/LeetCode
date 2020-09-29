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

namespace LeetCode.Solutions.LC494
{
    public class Solution
    {

        private int result;

        public int FindTargetSumWays(int[] nums, int S)
        {
            result = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            if (S > sum || (sum - S) % 2 != 0)
            {
                return 0;
            }

            int target = (sum - S) / 2;
            FindTarget(nums, 0, target);
            return result;
        }

        private bool FindTarget(int[] nums, int current, int target)
        {
            if (current == nums.Length)
            {
                if (target == 0)
                {
                    result++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            FindTarget(nums, current + 1, target - nums[current]);
            FindTarget(nums, current + 1, target);

            return true;
        }
    }
}