using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Repeated String

    There is a string, s, of lowercase English letters
    that is repeated infinitely many times. Given an integer, n,
    find and print the number of letter a's in the
    first n letters of the infinite string.

    Sample Input:
    a
    1000000000000

    Sample Output:
    1000000000000
    */
    public class RepeatedString
    {
        public static long repeatedString(string s, long n)
        {
            if (!s.Contains('a')) return 0;
            long countLetterA = 0;
            foreach (char item in s)
            {
                if (item == 'a') countLetterA++;
            }
            countLetterA=(n/s.Length)*countLetterA;
            for (int i = 0; i < n%s.Length; i++)
            {
                if(s[i]=='a') countLetterA++;
            }
            return countLetterA;
        }

        public static void Main(string[] args)
        {
            string s = "aba";

            long n = 10;

            Console.WriteLine(repeatedString(s, n));
        }
    }
}