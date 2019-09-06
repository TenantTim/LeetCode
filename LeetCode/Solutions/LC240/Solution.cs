using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.LC240
{
    public class Solution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return false;
            }

            int x = 0, y = matrix.GetLength(1) - 1;
            while (true)
            {
                if (target == matrix[x, y])
                {
                    return true;
                }
                else if (target > matrix[x, y])
                {
                    if (x == matrix.GetLength(0) - 1)
                    {
                        return false;
                    }
                    else
                    {
                        x++;
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        return false;
                    }
                    else
                    {
                        y--;
                    }
                }
            }
        }
    }
}
