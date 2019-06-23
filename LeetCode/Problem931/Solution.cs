using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem931
{
    public class Solution
    {
        public int MinFallingPathSum(int[][] A)
        {
            for(int row = 1; row < A.Length; row++)
            {
                for(int col = 0; col < A[row].Length; col++)
                {
                    int minValueAbove = int.MaxValue;

                    if(col != 0)
                        minValueAbove = Math.Min(minValueAbove, A[row - 1][col - 1]);
                    if(col != A[row].Length - 1)
                        minValueAbove = Math.Min(minValueAbove, A[row - 1][col + 1]);
                    minValueAbove = Math.Min(minValueAbove, A[row - 1][col]);

                    A[row][col] += minValueAbove;
                }
            }

            return A.Last().Min();
        }
    }
}
