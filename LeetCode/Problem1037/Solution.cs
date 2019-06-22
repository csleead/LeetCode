using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem1037
{
    public class Solution
    {
        public bool IsBoomerang(int[][] points)
        {
            return AreDistinctPoints(points) &&
                Slope(points[0], points[1]) != Slope(points[0], points[2]);
        }

        private bool AreDistinctPoints(int[][] points)
        {
            var p0 = points[0];
            var p1 = points[1];
            var p2 = points[2];

            return (p0[0] != p1[0] || p0[1] != p1[1])
                && (p0[0] != p2[0] || p0[1] != p2[1])
                && (p1[0] != p2[0] || p1[1] != p2[1]);
        }

        private double Slope(int[] p1, int[] p2)
        {
            if(p1[0] == p2[0])
                return double.PositiveInfinity;
            else
                return ((double)(p1[1] - p2[1])) / (p1[0] - p2[0]);
        }
    }
}
