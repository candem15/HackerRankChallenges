using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class ValidNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsNumber("-123.456e789"));
        }
        public static bool IsNumber(string s)
        {
            if (s == "") return false;
            if (s == "+" || s == "-") return false;
            if (s == "e" || s == "E") return false;
            if (s[s.Length - 1] == 'e' || s[s.Length - 1] == 'E') return false;
            if (s[s.Length - 1] == '+' || s[s.Length - 1] == '-') return false;
            if (s == "Infinity" || s == "-Infinity" || s == "+Infinity") return false;

            try
            {
                /// try to parse the number into a duble or decimal
                /// if casting to num failed, then break with false
                decimal num = decimal.Parse(s, System.Globalization.NumberStyles.Any);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}