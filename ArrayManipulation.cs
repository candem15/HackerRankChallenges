using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Array Manipulation

    Starting with a 1-indexed array of zeros and a list of operations,
    for each operation add a value to each the array element between two given indices,
    inclusive. Once all operations have been performed, return the maximum value in the array.

    Example:

    a b k
    1 5 3
    4 8 7
    6 9 1

    Add the values of  between the indices  and  inclusive:

    index->	 1 2 3  4  5 6 7 8 9 10
            [0,0,0, 0, 0,0,0,0,0, 0]
            [3,3,3, 3, 3,0,0,0,0, 0]
            [3,3,3,10,10,7,7,7,0, 0]
            [3,3,3,10,10,8,8,8,1, 0]

    The largest value is 8 after all operations are performed.
    */
    public class ArrayManipulation
    {
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            var list = new long[n];
            long max = long.MinValue, sum = 0;
            for (int i = 0; i < queries.Count; i++)
            {
                list[queries[i][0] - 1] += queries[i][2];
                if (queries[i][1] != n)
                    list[queries[i][1]] -= queries[i][2];
            }
            for (int i = 0; i < n; i++)
            {
                sum += list[i];
                if (max < sum) max = sum;
            }
            return max;
        }

        public static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            arr.Add(new List<int> { 2, 6, 8 });
            arr.Add(new List<int> { 3, 5, 7 });
            arr.Add(new List<int> { 1, 8, 1 });
            arr.Add(new List<int> { 5, 9, 15 });
            long result = arrayManipulation(10, arr);
            Console.WriteLine(result);
        }
    }
}