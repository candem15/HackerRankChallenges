using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Recusive Digit Sum

    We define super digit of an integer  using the following rules:

    Given an integer, we need to find the super digit of the integer.

    If  has only  digit, then its super digit is .
    Otherwise, the super digit of  is equal to the super digit of the sum of the digits of .
    For example, the super digit of  will be calculated as:

	super_digit(9875)   	9+8+7+5 = 29
	super_digit(29) 	2 + 9 = 11
	super_digit(11)		1 + 1 = 2
	super_digit(2)		= 2

    superDigit has the following parameter(s):

    string n: a string representation of an integer
    int k: the times to concatenate n to make superDigit(p)
    */
    public class RecusiveDigitSum
    {
        public static int superDigit(string n, int k)
        {
            if (n.Length == 1) return Int32.Parse(n.ToString());
            long result = 0;
            string number = n;
            while (k > 1)
            {
                number += n;
                k--;
            }
            for (int i = 0; i < number.Length; i++)
            {
                result += long.Parse(number[i].ToString());
            }
            return superDigit(result.ToString(), 0);
        }

        public static void Main(string[] args)
        {
            int result = superDigit("148", 3);

            Console.WriteLine(result);
        }
    }
}