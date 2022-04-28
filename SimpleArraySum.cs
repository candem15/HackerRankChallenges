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
    /* Simple Array Sum

    Given an array of integers, find the sum of its elements.

    Sample Input

    6
    1 2 3 4 10 11

    Sample Output

    31
    */
    class SimpleArraySum
    {

        /*
         * Complete the 'simpleArraySum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY ar as parameter.
         */

        public static int simpleArraySum(List<int> ar)
        {
            int result = 0;
            foreach (var item in ar)
            {
                result += item;
            }
            return result;
        }


        public static void Main(string[] args)
        {

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = SimpleArraySum.simpleArraySum(ar);

            Console.WriteLine(result);
            Console.Read();

        }
    }
}
