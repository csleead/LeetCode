using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problem1029
{
    public class Solution
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            return costs
                .OrderBy(c => c[0] - c[1])
                .Select((c, i) => (i < costs.Length / 2) ? c[0] : c[1])
                .Sum();
        }
    }
}
