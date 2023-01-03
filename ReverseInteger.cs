using System;
using System.Collections.Generic;

namespace TestConsoleApp
{
    /* Reverse Integer

    Given a signed 32-bit integer x, return x with its digits reversed.
    If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

    Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

    Example 1:
    Input: x = 123
    Output: 321

    Example 2:
    Input: x = -123
    Output: -321

    Example 3:
    Input: x = 120
    Output: 21


    Constraints:

    -231 <= x <= 231 - 1

    */
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            try
            {
                List<char> reverseList = new();
                bool negative = false;
                foreach (var item in x.ToString())
                {
                    reverseList.Add(item);
                }
                if (reverseList.Contains('-'))
                {
                    reverseList.Remove('-');
                    negative = true;
                }
                reverseList.Reverse();
                string result = new string(reverseList.ToArray());
                if (negative)
                    return -int.Parse(result);
                return int.Parse(result);
            }
            catch
            {
                return 0;
            }
        }
        public static void Main(string[] a)
        {
            var obj = new ReverseInteger();
            Console.WriteLine(obj.Reverse(1534236469));
        }
    }
}