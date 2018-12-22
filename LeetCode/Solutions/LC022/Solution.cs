using System.Collections.Generic;

/// <summary>
/// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
/// Sample:
///   3 =>
///   {
///      "((()))",
///      "(()())",
///      "(())()",
///      "()(())",
///      "()()()"
///   }
/// </summary>

// TODO: Explain this solution

namespace LeetCode.Solutions.LC022
{
   public class Solution
   {
      public IList<string> GenerateParenthesis( int n )
      {
         IList<string> result = new List<string>();

         GenerateParenthesis( 0, 0, n, "", result );

         return result;
      }

      private void GenerateParenthesis( int currentLefts, int currentRights, int sum, string currentStr, IList<string> result )
      {
         if( currentRights == sum )
         {
            result.Add( currentStr );
         }

         if( currentLefts < sum )
         {
            GenerateParenthesis( currentLefts + 1, currentRights, sum, currentStr + "(", result );
         }

         if( currentLefts > currentRights )
         {
            GenerateParenthesis( currentLefts, currentRights + 1, sum, currentStr + ")", result );
         }
      }
   }
}
