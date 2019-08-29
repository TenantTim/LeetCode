using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC845
{
    public class Solution
    {
        public int LongestMountain(int[] A)
        {
            int state = 0, curCount = 0, max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                {
                    state = 1;
                    curCount = 1;
                }
                else
                {
                    if (state == 1)
                    {
                        if (A[i] > A[i - 1])
                        {
                            curCount++;
                        }
                        else if (A[i] == A[i - 1])
                        {
                            curCount = 1;
                        }
                        else
                        {
                            curCount = curCount == 1 ? 1 : curCount + 1;
                            state = curCount == 1 ? 1 : 2;
                        }
                    }
                    else
                    {
                        if (A[i] >= A[i - 1])
                        {
                            if (curCount > max)
                            {
                                max = curCount;
                            }
                            curCount = A[i] > A[i - 1] ? 2 : 1;
                            state = 1;
                        }
                        else
                        {
                            curCount++;
                        }
                    }
                }
            }

            if (state == 2 && curCount > max)
            {
                return curCount;
            }
            else
                return max;
        }
    }
}
