using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem953
{
    public class Solution
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            if(words.Length == 1)
                return true;

            var orderDictionary = CreateOrderDictionary(order);

            for(int i = 1; i < words.Length; i++)
            {
                if(!IsSorted(words[i - 1], words[i], orderDictionary))
                {
                    return false;
                }
            }

            return true;
        }

        private static Dictionary<char, int> CreateOrderDictionary(string order)
        {
            var orderDictionary = new Dictionary<char, int>(order.Length);
            for(int i = 0; i < order.Length; i++)
            {
                orderDictionary.Add(order[i], i);
            }

            return orderDictionary;
        }

        private static bool IsSorted(string s1, string s2, Dictionary<char, int> orderDictionary)
        {
            if(s1 == s2)
                return true;

            for(int i = 0; i < s1.Length && i < s2.Length; i++)
            {
                int o1 = orderDictionary[s1[i]], o2 = orderDictionary[s2[i]];
                if(o1 > o2)
                    return false;
                else if(o1 < o2)
                    return true;
            }

            return s1.Length < s2.Length;
        }
    }
}
