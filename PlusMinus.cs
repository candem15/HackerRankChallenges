using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Plus Minus

    Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.

    Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

    Example

    There are  elements, two positive, two negative and one zero. Their ratios are ,  and . Results are printed as:

    0.400000
    0.400000
    0.200000

    Function Description

    Complete the plusMinus function in the editor below.

    plusMinus has the following parameter(s):

    int arr[n]: an array of integers
    Print
    Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with  digits after the decimal. The function should not return a value.

    Input Format:

    The first line contains an integer, , the size of the array.
    The second line contains  space-separated integers that describe .

    Output Format:

    Print the following  lines, each to  decimals:

    1-proportion of positive values
    2-proportion of negative values
    3-proportion of zeros
    */
    public class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            double minus=0,plus=0,zero=0;
            foreach (var item in arr)
            {
                if (item<0)
                {
                    minus++;
                }
                else if(item==0)
                {
                    zero++;
                }
                else
                {
                    plus++;
                }
            }
            var listLength=arr.Count;
            Console.WriteLine(Math.Round(plus/listLength,6));
            Console.WriteLine(Math.Round(minus/listLength,6));
            Console.WriteLine(Math.Round(zero/listLength,6));
        }

        public static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            arr.Add(-1);
            arr.Add(-1);
            arr.Add(1);
            arr.Add(0);
            arr.Add(-1);
            plusMinus(arr);
        }
    }
}