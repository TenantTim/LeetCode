using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solutions.LC1091
{
    public class Solution
    {
        private int[][] ways = new int[8][]
        {
        new int[] {-1, -1}, new int[] {-1, 0}, new int[] {-1, 1},
        new int[] { 0, -1},                    new int[] { 0, 1},
        new int[] { 1, -1}, new int[] { 1, 0}, new int[] { 1, 1},
        };

        private class Location
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            int n = grid.Length, step = 1;
            if (n == 1)
                return grid[0][0] == 1 ? -1 : 1;
            else if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
                return -1;

            Queue<Location> queue = new Queue<Location>();
            queue.Enqueue(new Location() { x = 0, y = 0 });

            while (queue.Any())
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    Location toExplore = queue.Dequeue();

                    if (toExplore.x == n - 1 && toExplore.y == n - 1)
                        return step;

                    for (int j = 0; j < 8; j++)
                    {
                        int xOnWay = toExplore.x + ways[j][0], yOnWay = toExplore.y + ways[j][1];
                        if (xOnWay < 0 || xOnWay >= n || yOnWay < 0 || yOnWay >= n || grid[xOnWay][yOnWay] != 0)
                            continue;

                        grid[xOnWay][yOnWay] = -1;
                        queue.Enqueue(new Location() { x = xOnWay, y = yOnWay });
                    }
                }
                step++;
            }
            return -1;
        }
    }
}
