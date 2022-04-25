using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Türkiye Finans .NET developer 5.Soru
    Assume that we have an array of positive integers from m to n which includes all odd numbers from m to n except one.

    Write a function that finds the missing odd number in the list.

    Example:

    Input: [1, 3, 5, 7, 9, 13, 15, 17]
    Output: 11

    Input: [9, 7, 3]
    Output: 5

    Constraints:

    1 < length of the input list (nums) < 100
    There is always a single missing number.
    Array is sorted either Descending or Ascending.

    */
    public class FindMissingNumberInTheArray
    {
        public static int FindNumber(int[] nums)
        {
            for (int i = nums.Min(); i < nums.Max(); i++)
            {
                if (i % 2 != 0 && !nums.Contains(i))
                    return i;
            }
            return 0;
        }
        public static void Main(string[] args)
        {
            var arr = new int[] { 1,9,7,3};
            Console.WriteLine(FindNumber(arr));
        }
    }
}