using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem973
{
    // We have a list of points on the plane.  Find the K closest points to the origin (0, 0).
    // (Here, the distance between two points on a plane is the Euclidean distance.)
    // You may return the answer in any order.  The answer is guaranteed to be unique (except for the order that it is in.)
    // Inputs
    // - 1 <= K <= points.length <= 10000
    // - -10000 < points[i][0] < 10000
    // - -10000 < points[i][1] < 10000
    public class Solution
    {
        public int[][] KClosest(int[][] points, int K)
        {
            if(points.Length <= K)
            {
                return points;
            }

            int from = 0, to = points.Length - 1;
            int pivotIndex;
            while((pivotIndex = Partition(points, from, to)) != K - 1)
            {
                if(pivotIndex > K - 1)
                {
                    to = pivotIndex - 1;
                }
                else
                {
                    from = pivotIndex + 1;
                }
            }

            var result = new int[K][];
            Array.Copy(points, result, K);
            return result;
        }

        public int Partition(int[][] points, int from, int to)
        {
            if(from + 1 == to)
            {
                if(Distance(points[from]) < Distance(points[to]))
                {
                    return from;
                }
                else
                {
                    Swap(points, from, to);
                    return to;
                }
            }

            int pivotDist = Distance(points[from]);
            int low = from + 1, high = to;

            while(low < high)
            {
                while(low < to && Distance(points[low]) <= pivotDist)
                {
                    low++;
                }

                while(high > from && Distance(points[high]) > pivotDist)
                {
                    high--;
                }

                if(low < high)
                {
                    Swap(points, low, high);
                }
            }

            Swap(points, from, high);

            return high;
        }

        private int Distance(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }

        private void Swap(int[][] points, int i, int j)
        {
            var temp = points[i];
            points[i] = points[j];
            points[j] = temp;
        }
    }
}
