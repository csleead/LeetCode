using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem789
{
    public class Solution
    {
        public bool EscapeGhosts(int[][] ghosts, int[] target)
        {
            var timeToEscape = Distance(new[] { 0, 0 }, target);
            foreach(var ghost in ghosts)
            {
                if(Distance(ghost, target) < timeToEscape)
                    return false;
            }

            return true;
        }

        private int Distance(int[] a, int[] b)
        {
            return Math.Abs(a[0] - b[0]) + Math.Abs(a[1] - b[1]);
        }
    }
}
