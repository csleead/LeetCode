using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LeetCode.Problem807
{
    public class Solution
    {
        // grid.length = grid[0].length
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var topViewSkyline = GetTopViewSkyline(grid);
            var leftViewSkyline = GetLeftViewSkyline(grid);

            int result = 0;
            for(int row = 0; row < grid.Length; row++)
            {
                for(int col = 0; col < grid.Length; col++)
                {
                    int d = Math.Min(topViewSkyline[col], leftViewSkyline[row]) - grid[row][col];
                    result += Math.Min(topViewSkyline[col], leftViewSkyline[row]) - grid[row][col];
                }
            }

            return result;
        }

        private int[] GetTopViewSkyline(int[][] grid)
        {
            int n = grid.Length;

            var result = new int[n];
            for(int col = 0; col < n; col++)
            {
                result[col] = grid[0][col];
                for(int row = 0; row < n; row++)
                {
                    result[col] = Math.Max(result[col], grid[row][col]);
                }
            }

            return result;
        }

        private int[] GetLeftViewSkyline(int[][] grid)
        {
            return grid.Select(row => row.Max()).ToArray();
        }
    }
}
