using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{

    /* Counting Inversions

    In an array, arr, the elements at indices i and j (where i<j ) form an inversion if arr[i]>arr[j].
    In other words, inverted elements arr[i] and arr[j] are considered to be "out of order".
    To correct an inversion, we can swap adjacent elements.

    Sample Input

    STDIN       Function
    -----       --------
    2           d = 2
    5           arr[] size n = 5 for the first dataset
    1 1 1 2 2   arr = [1, 1, 1, 2, 2]
    5           arr[] size n = 5 for the second dataset
    2 1 3 1 2   arr = [2, 1, 3, 1, 2]

    Sample Output

    0
    4
    */
    public class CountingInversions
    {
        public static long countInversions(List<int> arr)
        {
            var arrSorted = new List<int>(arr);
            arrSorted.Sort();
            int tempNumb = 0;
            long countInversions = 0;
            while (!arr.SequenceEqual(arrSorted))
            {
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        tempNumb = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tempNumb;
                        countInversions++;
                    }
                }
            }
            return countInversions;
        }
        public static void Main(string[] args)
        {
            var arr = new List<int> { 2, 1, 3, 1, 2 };
            Console.WriteLine(countInversions(arr));
        }
    }
}