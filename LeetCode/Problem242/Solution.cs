using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem242
{
    public class Solution
    {
        // inputs only contain lowercase letter
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
                return false;

            if(s.Length == 0)
                return true;

            var sArr = new int[26];
            var tArr = new int[26];
            Array.Fill(sArr, 0);
            Array.Fill(tArr, 0);

            int n = s.Length;
            for(int i = 0; i < n; i++)
            {
                sArr[s[i] - 'a']++;
                tArr[t[i] - 'a']++;
            }

            for(int i = 0; i < 26; i++)
            {
                if(sArr[i] != tArr[i])
                    return false;
            }

            return true;
        }
    }
}
