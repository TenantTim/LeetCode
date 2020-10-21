using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC0350
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> resultList = new List<int>();
            if (nums1.Length == 0 || nums2.Length == 0)
            {
                return resultList.ToArray();
            }

            Array.Sort(nums1);
            Array.Sort(nums2);

            int x = 0, y = 0;
            while (true)
            {
                if (x == nums1.Length || y == nums2.Length)
                {
                    break;
                }

                if (nums1[x] == nums2[y])
                {
                    resultList.Add(nums1[x]);
                    x++;
                    y++;
                }
                else if (nums1[x] < nums2[y])
                {
                    x++;
                }
                else
                {
                    y++;
                }
            }

            return resultList.ToArray();
        }
    }
}
