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
/*
FizzBuzz

Given a number n, for each integer fin the range from 1 to
inclusive, print one value per line as follows:

* If fis a multiple of both 3 and 5 print FizzBuzz.
* If fis a multiple of 3 (but not 9), print Fizz.

* If fis a multiple of 5 (but not 3, print Buzz.

* If fis nota multiple of 3or 5, print the value of #

Function Description
Complete the function fizzBuz in the editor below.

fizzBuzz has the following parameterisi:
int n: upper limit of values to test (inclusive)

Returns: NONE

Prints:

The function must print the appropriate response for each value /
in the set (1, 2... n}in ascending order, each on a separate line.

Example
Input:6
Output:
1
2
Fizz
4
Buzz
6

*/
    class Result
    {
        public static void fizzBuzz(int n)
        {
            var list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    list.Add("Fizz");
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                    list.Add("Buzz");
                else
                    list.Add(i.ToString());
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
    class fizzBuzz
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.fizzBuzz(n);
        }
    }
}