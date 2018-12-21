using System;

/// <summary>
/// https://leetcode.com/problems/median-of-two-sorted-arrays/
/// Find the median of the two sorted arrays.
/// The overall run time complexity should be O(log (m+n))
/// </summary>

// O(log(m + n)) solution
// Basically, what we are doing is to find the k-th smallest number
//    When k is specifically (m + n) / 2 here

namespace LeetCode.Solutions.LC004
{
   class BetterSolution
   {
      public double findMedianSortedArrays( int[] nums1, int[] nums2 )
      {
         int len = nums1.Length + nums2.Length;
         if( len % 2 == 0 )
         {
            return findKthNumberInTwoArray( nums1, nums2, 0, 0, len / 2 /*k*/ ) / 2
                + findKthNumberInTwoArray( nums1, nums2, 0, 0, len / 2 + 1 /*k*/ ) / 2;
         }
         else
         {
            return findKthNumberInTwoArray( nums1, nums2, 0, 0, len / 2 + 1 /*k*/ );
         }
      }

      // p is the start index of nums1, q is the start index of nums2, we wanna find the k-th number
      // in both nums1 & nums2
      public double findKthNumberInTwoArray( int[] nums1, int[] nums2, int p, int q, int k )
      {
         if( p >= nums1.Length ) return nums2[ q + k - 1 ];
         if( q >= nums2.Length ) return nums1[ p + k - 1 ];
         if( k == 1 ) return Math.Min( nums1[ p ], nums2[ q ] );

         int m = k / 2, n = k - m;
         
         // We want to either:
         //    1) Remove k/2 numbers from nums1 started from p or
         //    2) Remove k/2 numbers from nums2 started from q
         int aVal = int.MaxValue, bVal = int.MaxValue;
         if( p + m - 1 < nums1.Length ) aVal = nums1[ p + m - 1 ];
         if( q + n - 1 < nums2.Length ) bVal = nums2[ q + n - 1 ];

         if( aVal < bVal )
         {
            return findKthNumberInTwoArray( nums1, nums2, p + m, q, k - m );
         }
         else
         {
            return findKthNumberInTwoArray( nums1, nums2, p, q + n, k - n );
         }
      }
   }
}