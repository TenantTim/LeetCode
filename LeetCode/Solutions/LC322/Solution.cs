using System;

/// <summary>
/// https://leetcode.com/problems/coin-change/
/// Write a function to compute the fewest number of coins that you need to make up that amount.
/// Sample:
///   ({1, 2, 5}, 11) => 3 // 11 = 5 + 5 + 1
///   ({2}, 3) => -1 // Cannot make up 3 with 2
/// </summary>

// DP with the amount, start with 1

namespace LeetCode.Solutions.LC322
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (coins == null || coins.Length == 0)
                return -1;

            int maxValue = amount + 1;
            int[] m_solutions = new int[maxValue];
            m_solutions[0] = 0;

            for (int sum = 1; sum <= amount; sum++)
            {
                int bestSolution = maxValue;
                for (int i = 0; i < coins.Length; i++)
                {
                    bestSolution = sum >= coins[i] ?
                        Math.Min(bestSolution, m_solutions[sum - coins[i]] + 1) :
                        bestSolution;
                }
                m_solutions[sum] = bestSolution;
            }

            return m_solutions[amount] == maxValue ? -1 : m_solutions[amount];
        }
    }
}
