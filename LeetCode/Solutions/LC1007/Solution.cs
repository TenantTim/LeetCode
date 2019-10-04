using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC1007
{
    public class Solution
    {
        public int MinDominoRotations(int[] A, int[] B)
        {
            if (A.Length <= 1)
            {
                return 0;
            }

            int pivot1 = A[0], pivot2 = B[0] == A[0] ? -1 : B[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == pivot1 || B[i] == pivot1)
                    continue;
                else
                {
                    pivot1 = -1;
                    break;
                }
            }

            if (pivot2 != -1)
            {
                for (int i = 1; i < A.Length; i++)
                {
                    if (A[i] == pivot2 || B[i] == pivot2)
                        continue;
                    else
                    {
                        pivot2 = -1;
                        break;
                    }
                }
            }

            if (pivot1 == -1 && pivot2 == -1)
                return -1;

            int min = 30000;
            if (pivot1 != -1)
            {
                int count1 = 0, count2 = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    count1 += A[i] != pivot1 ? 1 : 0;
                    count2 += B[i] != pivot1 ? 1 : 0;
                }
                min = count1 < min ? count1 : min;
                min = count2 < min ? count2 : min;
            }

            if (pivot2 != -1)
            {
                int count1 = 0, count2 = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    count1 += A[i] != pivot2 ? 1 : 0;
                    count2 += B[i] != pivot2 ? 1 : 0;
                }
                min = count1 < min ? count1 : min;
                min = count2 < min ? count2 : min;
            }

            return min;
        }
    }
}
