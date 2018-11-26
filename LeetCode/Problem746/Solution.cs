using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem746
{
    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var minCosts = new int[cost.Length];
            minCosts[0] = cost[0];
            minCosts[1] = cost[1];

            for(int i = 2; i < cost.Length; i++)
            {
                minCosts[i] = cost[i] + Math.Min(minCosts[i - 1], minCosts[i - 2]);
            }

            return Math.Min(minCosts[cost.Length - 1], minCosts[cost.Length - 2]);
        }
    }
}
