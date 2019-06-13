using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem1078
{
    public class Solution
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if(words.Length < 3)
                return new string[0];

            var result = new List<string>();
            for(int i = 2; i < words.Length; i++)
            {
                if(words[i - 2] == first && words[i - 1] == second)
                {
                    result.Add(words[i]);
                }
            }

            return result.ToArray();
        }
    }
}
