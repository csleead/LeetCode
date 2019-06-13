using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem1021
{
    public class Solution
    {
        public string RemoveOuterParentheses(string S)
        {
            var stack = new Stack<char>(S.Length);
            var list = new List<char>(S.Length);
            foreach(var c in S)
            {
                if(c == '(')
                {
                    if(stack.Count != 0)
                        list.Add(c);

                    stack.Push(c);
                }
                else
                {
                    if(stack.Count != 1)
                        list.Add(c);

                    stack.Pop();
                }
            }

            return new string(list.ToArray());
        }
    }
}
