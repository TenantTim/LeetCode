using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
/// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.
/// Sample:
///   "23" => {"ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"}
/// </summary>

// Iterate each character, add new possible results and remove the old ones

namespace LeetCode.Solutions.LC017
{
   public class Solution
   {
      static Dictionary<char, List<char>> dict = new Dictionary<char, List<char>>
       {
         {'2', new List<char> { 'a', 'b','c' }},
         {'3', new List<char> { 'd', 'e','f' }},
         {'4', new List<char> { 'g', 'h','i' }},
         {'5', new List<char> { 'j', 'k','l' }},
         {'6', new List<char> { 'm', 'n','o' }},
         {'7', new List<char> { 'p', 'q','r','s' }},
         {'8', new List<char> { 't', 'u','v' }},
         {'9', new List<char> { 'w','x','y','z' }},
       };

      public IList<string> LetterCombinations( string digits )
      {

         List<string> result = new List<string>();

         foreach( char c in digits.ToCharArray() )
         {
            if( result.Count == 0 )
            {
               dict[ c ].ForEach( ch => result.Add( ch.ToString() ) );
            }
            else
            {
               int currentCount = result.Count;
               dict[ c ].ForEach( ch =>
               {
                  for( int i = 0; i < currentCount; i++ )
                  {
                     result.Add( string.Concat( result[ i ], ch.ToString() ) );
                  }
               } );
               for( int i = currentCount - 1; i >= 0; i-- )
               {
                  result.RemoveAt( i );
               }
            }
         }

         return result;
      }
   }
}
