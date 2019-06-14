using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem482
{
    public class Solution
    {
        public string LicenseKeyFormatting(string S, int K)
        {
            var arr = new char[S.Length * 2];
            var arrIndex = arr.Length - 1;

            int letterCount = 0;
            for(int i = S.Length - 1; i >= 0; i--)
            {
                if(S[i] == '-')
                    continue;

                if(letterCount > 0 && letterCount % K == 0)
                {
                    arr[arrIndex] = '-';
                    arrIndex--;
                }

                arr[arrIndex] = ToUpper(S[i]);
                arrIndex--;
                letterCount++;
            }

            return new string(arr, arrIndex + 1, arr.Length - arrIndex - 1);
        }

        private static char ToUpper(char c)
        {
            return (c >= 'a') ? (char)(c - 'a' + 'A') : c;
        }
    }
}
