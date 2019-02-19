using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem696
{
    // Give a string s, count the number of non-empty (contiguous) substrings
    // that have the same number of 0's and 1's, and all the 0's and all the
    // 1's in these substrings are grouped consecutively.
    // Substrings that occur multiple times are counted the number of times they occur.
    public class Solution
    {
        public int CountBinarySubstrings(string s)
        {
            int result = 0;

            var currentChar = s[0];
            int charCount1 = 0, charCount2 = 0;
            foreach(var c in s)
            {
                if(c == currentChar)
                {
                    charCount2++;
                }
                else
                {
                    result += Math.Min(charCount1, charCount2);
                    charCount1 = charCount2;
                    charCount2 = 1;
                    currentChar = c;
                }
            }

            result += Math.Min(charCount1, charCount2);
            return result;
        }
    }
}
