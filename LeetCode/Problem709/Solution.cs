using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem709
{
    public class Solution
    {
        public string ToLowerCase(string str)
        {
            const int offset = 'a' - 'A';
            var arr = str.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    arr[i] = (char)(arr[i] + offset);
                }
            }

            return new string(arr);
        }
    }
}
