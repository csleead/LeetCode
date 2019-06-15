using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem547
{
    public class Solution
    {
        public int FindCircleNum(int[][] M)
        {
            var reached = new bool[M.Length];
            Array.Fill(reached, false);

            int count = 0;
            for(int i = 0; i < M.Length; i++)
            {
                if(!reached[i])
                {
                    count++;
                    DepthFirstSearch(i, M, reached);
                }
            }

            return count;
        }

        private void DepthFirstSearch(int student, int[][] M, bool[] reached)
        {
            reached[student] = true;

            for(int i = 0; i < M.Length; i++)
            {
                if(!reached[i] && M[student][i] == 1)
                {
                    DepthFirstSearch(i, M, reached);
                }
            }
        }
    }
}
