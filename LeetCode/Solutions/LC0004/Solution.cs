using System;

/// <summary>
/// https://leetcode.com/problems/median-of-two-sorted-arrays/
/// Find the median of the two sorted arrays.
/// The overall run time complexity should be O(log (m+n))
/// </summary>

// This is an O(m + n) solution
// Basically, just make sure there are 2 numbers being removed in each iteration
// And end when there are less than 2 numbers left

namespace LeetCode.Solutions.LC0004
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int head1 = 0, head2 = 0, tail1 = nums1.Length - 1, tail2 = nums2.Length - 1;

            while (true)
            {
                if (tail1 - head1 + tail2 - head2 <= 0)
                {
                    double sum = 0;
                    sum += (tail1 > head1) ? nums1[tail1] : 0;
                    sum += (tail1 >= head1 && nums1.Length != 0) ? nums1[head1] : 0;
                    sum += (tail2 > head2) ? nums2[tail2] : 0;
                    sum += (tail2 >= head2 && nums2.Length != 0) ? nums2[head2] : 0;
                    return (sum / (tail1 - head1 + tail2 - head2 + 2));
                }

                if (head1 > tail1)
                {
                    head2++;
                    tail2--;
                    continue;
                }

                if (head2 > tail2)
                {
                    head1++;
                    tail1--;
                    continue;
                }

                if (nums1[head1] <= nums2[head2])
                    head1++;
                else
                    head2++;

                if (head1 <= tail1 && (nums1[tail1] >= nums2[tail2]))
                    tail1--;
                else
                    tail2--;
            }
        }
    }
}