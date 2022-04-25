using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Diagonal Difference

    Given a square matrix, calculate the absolute difference between the sums of its diagonals.

    For example, the square matrix  is shown below:

    1 2 3
    4 5 6
    9 8 9

    The left-to-right diagonal : 1+5+9=15. The right to left diagonal : 3+5+9=17 . Their absolute difference is |15-17|=2.
    */
    public class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int diag1 = 0, diag2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        diag1 += arr[i][j];
                    }
                    if (i + j == arr.Count - 1)
                    {
                        diag2 += arr[i][j];
                    }
                }
            }
            return Math.Abs(diag1 - diag2);
        }
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);
        }
    }
}