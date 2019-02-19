using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem733
{
    public class Solution
    {
        public int[,] FloodFill(int[,] image, int sr, int sc, int newColor)
        {
            var oldColor = image[sr, sc];
            var result = image.Clone() as int[,];
            if(oldColor == newColor)
            {
                return result;
            }

            var stack = new Stack<(int r, int c)>();
            stack.Push((sr, sc));
            while(stack.Count > 0)
            {
                var (r, c) = stack.Pop();
                result[r, c] = newColor;

                if(IsInImage(r - 1, c, result) && result[r - 1, c] == oldColor)
                    stack.Push((r - 1, c));

                if(IsInImage(r + 1, c, result) && result[r + 1, c] == oldColor)
                    stack.Push((r + 1, c));

                if(IsInImage(r, c - 1, result) && result[r, c - 1] == oldColor)
                    stack.Push((r, c - 1));

                if(IsInImage(r, c + 1, result) && result[r, c + 1] == oldColor)
                    stack.Push((r, c + 1));
            }

            return result;
        }

        private bool IsInImage(int r, int c, int[,] image)
        {
            return r >= 0 && c >= 0 && r < image.GetLength(0) && c < image.GetLength(1);
        }
    }
}
