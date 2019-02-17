using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem860
{
    public class Solution
    {
        // At a lemonade stand, each lemonade costs $5.
        // Customers are standing in a queue to buy from you, and order one at a time(in the order specified by bills).
        // Each customer will only buy one lemonade and pay with either a $5, $10, or $20 bill.
        // You must provide the correct change to each customer, so that the net transaction is that the customer pays $5.
        // Note that you don't have any change in hand at first.
        // Return true if and only if you can provide every customer with correct change.
        public bool LemonadeChange(int[] bills)
        {
            int count5 = 0, count10 = 0, count20 = 0;

            foreach(var b in bills)
            {
                if(b == 5)
                {
                    count5++;
                }
                else if(b == 10)
                {
                    if(count5 > 0)
                    {
                        count10++;
                        count5--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    // b == 20
                    if(count10 > 0 && count5 > 0)
                    {
                        count20++;
                        count5--;
                        count10--;
                    }
                    else if(count5 >= 3)
                    {
                        count20++;
                        count5 -= 3;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
