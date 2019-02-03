using System.Linq;

namespace LeetCode.Problem985
{
    // We have an array A of integers, and an array queries of queries.
    // For the i-th query val = queries[i][0], index = queries[i][1], we add val to A[index].
    // Then, the answer to the i-th query is the sum of the even values of A.
    // (Here, the given index = queries[i][1] is a 0-based index, and each query permanently modifies the array A.)
    // Return the answer to all queries.  Your answer array should have answer[i] as the answer to the i-th query.
    // - 1 <= A.length <= 10000
    // - -10000 <= A[i] <= 10000
    // - 1 <= queries.length <= 10000
    // - -10000 <= queries[i][0] <= 10000
    // - 0 <= queries[i][1] < A.length
    public class Solution
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var helper = new Helper(A);

            var result = new int[queries.Length];
            for(int i = 0; i < queries.Length; i++)
            {
                result[i] = helper.AddTo(queries[i][1], queries[i][0]);
            }
            return result;
        }

        private class Helper
        {
            private int[] _arr;
            private int _evenSum;

            public Helper(int[] arr)
            {
                _arr = arr;
                _evenSum = arr.Where(i => i % 2 == 0).Sum();
            }

            public int AddTo(int index, int value)
            {
                if(_arr[index] % 2 == 0)
                {
                    _evenSum -= _arr[index];
                }

                _arr[index] += value;
                if(_arr[index] % 2 == 0)
                {
                    _evenSum += _arr[index];
                }

                return _evenSum;
            }
        }
    }
}
