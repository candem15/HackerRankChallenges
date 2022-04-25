using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Making Anagrams

    A student is taking a cryptography class and has found anagrams to be very useful.
    Two strings are anagrams of each other if the first string's letters can be
    rearranged to form the second string. In other words,
    both strings must contain the same exact letters in the same exact frequency.
    For example, bacdc and dcbac are anagrams, but bacdc and dcbad are not.

    The student decides on an encryption scheme that involves two large strings.
    The encryption is dependent on the minimum number of character deletions
    required to make the two strings anagrams. Determine this number.

    Given two strings, a and b, that may or may not be of the same length,
    determine the minimum number of character deletions required to make  and  anagrams.
    Any characters can be deleted from either of the strings.

    Sample Input

    cde
    abc

    Sample Output

    4

    Explanation

    Delete the following characters from the strings make them anagrams:

    Remove d and e from cde to get c.
    Remove a and b from abc to get c.
    It takes 4 deletions to make both strings anagrams.
    */
    public class MakingAnagrams
    {
        public static int makeAnagram(string a, string b)
        {
            List<int> list = new List<int>(new int[26]);
            int total = 0;
            foreach (char item in a) { list[item - 'a']++; }
            foreach (char item in b) { list[item - 'a']--; }
            foreach (int item in list) { total += Math.Abs(item); }
            return total;
        }

        public static void Main(string[] args)
        {
            string a = "fcrxzwscanmligyxyvym";

            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

            int res = makeAnagram(a, b);

            Console.WriteLine(res);
        }
    }
}