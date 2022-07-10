using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Integer To Roman

    For example, 2 is written as II in Roman numeral, just two one's added together.
    12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

    Roman numerals are usually written largest to smallest from left to right.
    However, the numeral for four is not IIII. Instead, the number four is written as IV.
    Because the one is before the five we subtract it making four.
    The same principle applies to the number nine, which is written as IX.
    There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9.
    X can be placed before L (50) and C (100) to make 40 and 90.
    C can be placed before D (500) and M (1000) to make 400 and 900.
    Given an integer, convert it to a roman numeral.



    Example 1:
    Input: num = 3
    Output: "III"
    Explanation: 3 is represented as 3 ones.

    Example 2:
    Input: num = 58
    Output: "LVIII"
    Explanation: L = 50, V = 5, III = 3.

    Example 3:
    Input: num = 1994
    Output: "MCMXCIV"
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

    */
    public class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            string result = "";
            while (num >= 1000)
            {
                result += 'M';
                num -= 1000;
            }
            while (num >= 900)
            {
                result += "CM";
                num -= 900;
            }
            while (num >= 500)
            {
                result += 'D';
                num -= 500;
            }
            while (num >= 400)
            {
                result += "CD";
                num -= 400;
            }
            while (num >= 100)
            {
                result += 'C';
                num -= 100;
            }
            while (num >= 90)
            {
                result += "XC";
                num -= 90;
            }
            while (num >= 50)
            {
                result += 'L';
                num -= 50;
            }
            while (num >= 40)
            {
                result += "XL";
                num -= 40;
            }
            while (num >= 10)
            {
                result += 'X';
                num -= 10;
            }
            while (num >= 9)
            {
                result += "IX";
                num -= 9;
            }
            while (num >= 5)
            {
                result += 'V';
                num -= 5;
            }
            while (num == 4)
            {
                result += "IV";
                num -= 5;
            }
            while (num >= 1)
            {
                result += 'I';
                num -= 1;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            var obj = new IntegerToRoman();
            Console.WriteLine(obj.IntToRoman(1994));
        }
    }
}