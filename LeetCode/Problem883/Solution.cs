using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problem883
{
    public class Solution
    {
        public int ProjectionArea(int[][] grid)
        {
            return TopViewArea(grid) + SideViewArea(grid) + FrontViewArea(grid);
        }

        private int TopViewArea(int[][] grid)
        {
            return grid.SelectMany(g => g).Count(i => i > 0);
        }

        private int SideViewArea(int[][] grid)
        {
            return grid.Select(row => row.Max()).Sum();
        }

        private int FrontViewArea(int[][] grid)
        {
            int sum = 0;

            int n = grid.Length;
            for(int col = 0; col < n; col++)
            {
                int max = 0;
                for(int row = 0; row < n; row++)
                {
                    max = Math.Max(grid[row][col], max);
                }
                sum += max;
            }

            return sum;
        }
    }
}
