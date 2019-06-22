using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem278
{
    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int low = 1, up = n;
            while(low < up)
            {
                checked
                {
                    var version = low + (up - low) / 2;

                    if(IsBadVersion(version))
                    {
                        up = version;
                    }
                    else
                    {
                        low = version + 1;
                    }
                }
            }

            return up;
        }
    }
}
