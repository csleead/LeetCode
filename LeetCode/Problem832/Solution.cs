using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem832
{
    public class Solution
    {
        // Given a binary matrix A, we want to flip the image horizontally, then invert it, and return the resulting image.
        // To flip an image horizontally means that each row of the image is reversed. For example, flipping [1, 1, 0] horizontally results in [0, 1, 1].
        // To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0. For example, inverting [0, 1, 1] results in [1, 0, 0].
        // input assumptions:
        // - A is a square matrix
        // - A.Length >= 1
        // - A[i][j] must be 0 or 1
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int n = A.Length;

            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n / 2; col++)
                {
                    int left = A[row][col];
                    int right = A[row][n - col - 1];

                    A[row][col] = Invert(right);
                    A[row][n - col - 1] = Invert(left);
                }

                if(n % 2 == 1)
                {
                    A[row][n / 2] = Invert(A[row][n / 2]);
                }
            }

            return A;
        }

        private int Invert(int i)
        {
            return i == 0 ? 1 : 0;
        }
    }
}
