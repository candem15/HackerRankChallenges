using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Minimum Swaps 2

    You are given an unordered array
    consisting of consecutive integers E [1, 2, 3, ..., n]
    without any duplicates. You are allowed to swap any two elements.
    Find the minimum number of swaps required to sort
    the array in ascending order.

    Example:
    Perform the following steps:

    arr = [7, 1, 3, 2, 4, 5, 6]

    i   arr                     swap (indices)
    0   [7, 1, 3, 2, 4, 5, 6]   swap (0,3)
    1   [2, 1, 3, 7, 4, 5, 6]   swap (0,1)
    2   [1, 2, 3, 7, 4, 5, 6]   swap (3,4)
    3   [1, 2, 3, 4, 7, 5, 6]   swap (4,5)
    4   [1, 2, 3, 4, 5, 7, 6]   swap (5,6)
    5   [1, 2, 3, 4, 5, 6, 7]

    It took 5 swaps to sort the array.
    */
    public class MinimumSwaps2
    {
        static int minimumSwaps(int[] arr)
        {
            int swapCount = 0, swapIndex = 0, valueAtCurrentIndex = 0, valueAtSwapIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] != i + 1)
                {
                    swapIndex = arr[i] - 1;
                    valueAtCurrentIndex = arr[i];
                    valueAtSwapIndex = arr[swapIndex];
                    arr[swapIndex] = valueAtCurrentIndex;
                    arr[i] = valueAtSwapIndex;
                    swapCount++;
                }
            }
            return swapCount;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5] { 2, 3, 4, 1, 5 };
            int res = minimumSwaps(arr);
            Console.WriteLine(res);
        }
    }
}