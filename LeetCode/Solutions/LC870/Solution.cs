using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solutions.LC870
{
    public class Solution
    {
        public int[] AdvantageCount(int[] A, int[] B)
        {
            int[] C = Enumerable.Range(0, A.Length).ToArray();
            Array.Sort(A);
            Array.Sort(B, C);

            int[] result = new int[A.Length];
            int end = A.Length - 1, cur = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > B[cur])
                {
                    result[cur] = A[i];
                    cur++;
                }
                else
                {
                    result[end] = A[i];
                    end--;
                }
            }
            Array.Sort(C, result);
            return result;
        }
    }
}
