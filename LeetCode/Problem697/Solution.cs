using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem697
{
    public class Solution
    {
        public int FindShortestSubArray(int[] nums)
        {
            var infoDic = new Dictionary<int, Info>();

            int maxDegree = 0;
            int result = int.MaxValue;
            for(int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];

                var info = infoDic.GetValueOrDefault(n);
                if(info == null)
                {
                    infoDic.Add(n, new Info { FirstOccurenceIndex = i, Degree = 1 });
                }
                else
                {
                    info.Degree++;
                    if(info.Degree > maxDegree)
                    {
                        maxDegree = info.Degree;
                        result = i - info.FirstOccurenceIndex + 1;
                    }
                    else if(info.Degree == maxDegree)
                    {
                        result = Math.Min(result, i - info.FirstOccurenceIndex + 1);
                    }
                }
            }

            return result == int.MaxValue ? 1 : result;
        }

        private class Info
        {
            public int FirstOccurenceIndex { get; set; }
            public int Degree { get; set; }
        }
    }
}
