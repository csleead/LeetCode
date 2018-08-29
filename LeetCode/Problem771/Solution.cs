using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem771
{
    public class Solution
    {
        public int NumJewelsInStones(string J, string S)
        {
            var jSet = new HashSet<char>(J);
            int result = 0;
            foreach (var c in S)
            {
                if (jSet.Contains(c))
                    result++;
            }
            return result;
        }
    }
}
