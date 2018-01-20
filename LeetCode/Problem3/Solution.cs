using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(s == string.Empty)
                return 0;

            int low = 0, high = 0, answer = 0;
            var dic = new Dictionary<char, int>();

            while(high < s.Length)
            {
                char c = s[high];
                dic.TryAdd(c, 0);

                dic[c]++;
                if(dic[c] == 2)
                {
                    while(true)
                    {
                        low++;
                        dic[s[low - 1]]--;
                        if(s[low - 1] == c)
                            break;
                    }
                }

                answer = Math.Max(answer, high - low + 1);
                high++;
            }

            return answer;
        }
    }
}
