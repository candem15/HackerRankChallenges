using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class NumberOfOccurrences
    {
        /* Türkiye Finans .NET developer 10.Soru
        Find the absolute difference between the number of occurrences.
        310 seconds

        Given a string `s` consists of characters 'A' and 'B' only, find the absolute difference between their number of occurrences.

        Example:

        Input: "AAABAB"
        Output: 2

        Input: "AAAAAAAAB"
        Output: 7

        Input: "BB"
        Output: 2

        Constraints:

        0 <= len(s) <= 100
        All characters in `s` are either 'A' or 'B'.
        */
        public static int Difference(string text)
        {
            int aCount = 0, bCount = 0;
            foreach (var item in text)
            {
                if (item == 'A') aCount++;
                else if (item == 'B') bCount++;
            }
            return Math.Abs(aCount-bCount);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Difference("BB"));
        }
    }
}