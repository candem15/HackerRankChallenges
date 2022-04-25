using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Ransom Note

    Harold is a kidnapper who wrote a ransom note,
    but now he is worried it will be traced back to him through his handwriting.
    He found a magazine and wants to know if he can cut out whole words from it
    and use them to create an untraceable replica of his ransom note.
    The words in his note are case-sensitive and he must use only whole words available in the magazine.
    He cannot use substrings or concatenation to create the words he needs.

    Given the words in the magazine and the words in the ransom note,
    print Yes if he can replicate his ransom note exactly using whole words from the magazine;
    "Yes" otherwise, print "No".

    Sample Input:
    6 5
    two times three is not four
    two times two is four

    Sample Output:
    No

    Explanation:
    'two' only occurs once in the magazine.
    */
    public class RansomNote
    {
        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            magazine.Sort();
            note.Sort();
            for (int i = 0; i < note.Count; i++)
            {
                if(!magazine.Remove(note[i]))
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
        public static void Main(string[] args)
        {
            List<string> magazine = new List<string> { "apgo", "clm", "w", "lxkvg", "mwz", "elo", "bg", "elo", "lxkvg", "elo", "apgo", "apgo", "w", "elo", "bg" };

            List<string> note = new List<string> { "elo", "lxkvg", "bg", "mwz", "clm", "w" };

            checkMagazine(magazine, note);
        }
    }
}