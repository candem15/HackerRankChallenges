using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace TestConsoleApp
{
    /* Find Median

    The median of a list of numbers is essentially its middle element after sorting.
    The same number of elements occur after it as before.
    Given a list of numbers with an odd number of elements, find the median one?

    Sample Input

    7
    0 1 2 4 6 5 3

    Sample Output

    3

    Explanation

    sorted array = 0-1-2-3-4-5-6 middle element is at positon 3 => 3
    */

    class FindMedian
    {

        /*
         * Complete the 'findMedian' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            int median = ((arr.Count - 1) / 2) + 1;
            return arr[median - 1];
        }
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = findMedian(arr);

            Console.WriteLine(result);

            Console.Read();
        }
    }
}