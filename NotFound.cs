using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Not Found

    Problem Statement
    You are given a string
    S consisting of lowercase English letters. Find the lexicographically (alphabetically) smallest lowercase English letter that does not occur in
    S. If every lowercase English letter occurs in
    S, print None instead.

    Constraints
    1≤∣S∣≤10
    5
    (
    ∣S∣ is the length of string
    S.)
    S consists of lowercase English letters.
    Input
    Input is given from Standard Input in the following format:

    S
    Output
    Print the lexicographically smallest lowercase English letter that does not occur in
    S. If every lowercase English letter occurs in
    S, print None instead.

    Sample Input 1
    atcoderregularcontest
    Sample Output 1
    b
    The string atcoderregularcontest contains a, but does not contain b.

    Sample Input 2
    abcdefghijklmnopqrstuvwxyz
    Sample Output 2
    None
    This string contains every lowercase English letter.

    Sample Input 3
    fajsonlslfepbjtsaayxbymeskptcumtwrmkkinjxnnucagfrg
    Sample Output 3
    d
*/
    public class NotFound
    {
        public static string lexicographicallyLetter(string text)
        {
            var letters = "abcdefghijklmnopqrstuvwxyz";
            foreach (char letter in text)
            {
                letters = letters.Replace(letter.ToString(), string.Empty);
            }

            return letters.Length > 0 ? letters[0].ToString() : "Not Found";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(lexicographicallyLetter("fajsonlslfepbjtsaayxbymeskptcumtwrmkkinjxnnucagfrg")); //Must return 'd'
            Console.Read();
        }

    }
}