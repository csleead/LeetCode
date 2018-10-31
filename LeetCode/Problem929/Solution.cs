using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem929
{
    public class Solution
    {
        public int NumUniqueEmails(string[] emails)
        {
            return emails.Select(Process).ToHashSet().Count;
        }

        private static string Process(string email)
        {
            var split = email.Split('@');
            split[0] = split[0].Replace(".", string.Empty);
            if(split[0].IndexOf("+") > 0)
            {
                split[0] = split[0].Substring(0, split[0].IndexOf("+"));
            }

            return split[0] + split[1];
        }
    }
}
