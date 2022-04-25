using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{

    /* Sherlock And Valid String

    Sherlock considers a string to be valid if all characters of the string appear the same number of times.
    It is also valid if he can remove just 1 character at 1 index in the string,
    and the remaining characters will occur the same number of times.
    Given a string s, determine if it is valid. If so, return YES, otherwise return NO.

    Sample Input 1

    aabbccddeefghi

    Sample Output 1

    NO

    Sample Input 2

    abcdefghhgfedecba

    Sample Output 2

    YES
    */
    public class SherlockAndValidString
    {
        public static string isValid(string s)
        {
            var list = new List<int>(new int[26]);
            foreach (char item in s)
                list[item - 'a']++;
            var set = new HashSet<int>();
            int numberOne = 0;
            foreach (var item in list)
            {
                if (item == 1) numberOne++;
                set.Add(item);
            }
            set.Remove(0);
            if (set.Count > 2) return "NO";
            list = set.ToList();
            if (numberOne==1) return "YES";
            if ((list.Count > 1 && Math.Abs(list[0] - list[1]) > 1) && numberOne > 1) return "NO";
            return "YES";
        }

        public static void Main(string[] args)
        {

            string s = "aaaabbcc";

            Console.WriteLine(isValid(s));
        }
    }
}