using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* 2D Array - DS

    Example

    -9 -9 -9  1 1 1
    0 -9  0  4 3 2
    -9 -9 -9  1 2 3
    0  0  8  6 6 0
    0  0  0 -2 0 0
    0  0  1  2 4 0

    The  hourglass sums are:

    -63, -34, -9, 12,
    -10,   0, 28, 23,
    -27, -11, -2, 10,
      9,  17, 25, 18

    The highest hourglass sum is 28 from the hourglass
    beginning at row 1, column 2:

    0 4 3
      1
    8 6 6

    */
    public class Hourglasses
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int maxSum = int.MinValue, currentSum = 0;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    currentSum = arr[i][j] + arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    if (currentSum > maxSum) maxSum = currentSum;
                }
            }
            return maxSum;
        }

        public static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            arr.Add(new List<int>{0 ,-4 ,-6 ,0 ,-7 ,-6});
            arr.Add(new List<int>{-1 ,-2 ,-6 ,-8 ,-3 ,-1});
            arr.Add(new List<int>{-8 ,-4 ,-2 ,-8 ,-8 ,-6});
            arr.Add(new List<int>{-3 ,-1 ,-2 ,-5 ,-7 ,-4});
            arr.Add(new List<int>{-3 ,-5 ,-3 ,-6 ,-6 ,-6});
            arr.Add(new List<int>{-3 ,-6 ,0 ,-8 ,-6 ,-7});

            Console.WriteLine(hourglassSum(arr));
        }
    }
}