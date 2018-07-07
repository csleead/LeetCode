using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem739
{
    public class Solution
    {
        private static readonly int MaxTemperature = 100;

        public int[] DailyTemperatures(int[] temperatures)
        {
            var earliestTempDic = new Dictionary<int, int>();
            int[] result = new int[temperatures.Length];
            for(int i = temperatures.Length - 1; i >= 0; i--)
            {
                var warmerIndex = FindSmallestIndexOfWarmerTemperature(temperatures[i], earliestTempDic);
                result[i] = (warmerIndex == -1) ? 0 : warmerIndex - i;

                earliestTempDic[temperatures[i]] = i;
            }

            return result;
        }

        private static int FindSmallestIndexOfWarmerTemperature(int temperature, Dictionary<int, int> earliestTempDic)
        {
            int result = int.MaxValue;
            for(int t = temperature + 1; t <= MaxTemperature; t++)
            {
                var index = earliestTempDic.GetValueOrDefault(t);
                if(index != 0)
                {
                    result = Math.Min(result, index);
                }
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}
