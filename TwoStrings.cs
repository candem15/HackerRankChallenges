using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /*
    Given two strings, determine if they share a common substring. A substring may be as small as one character.

    Example
    s1 = "and"
    s2 = "art"

    These share the common substring 'a'.

    s1 = "be"
    s2 = "cat"

    These do not share a substring.

    Function Description

    Complete the function twoStrings in the editor below.

    twoStrings has the following parameter(s):

    string s1: a string
    string s2: another string

    Returns
    string: either YES or NO

    Sample Input:

    2
    hello
    world
    hi
    world

    Sample Output:

    YES
    NO

    */
    public class TwoStrings
    {
        public static string twoStrings(string s1, string s2)
        {
            var var1=s1.ToCharArray().Distinct();
            var var2=s2.ToCharArray().Distinct();
            return var1.Any(y=>var2.Any(x=>x==y))?"YES":"NO";
        }
        public static void Main(string[] args)
        {
                string s1 = "hiiiii";

                string s2 = "world";

                Console.WriteLine(twoStrings(s1, s2));
        }
    }
}