using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /*
    1. Substring Search

    Given a string, how many different substrings exist in it that have no repeating characters? Two substrings are considered different if they have a different start or end index.
    Example
    s="abac"
    The substrings that have no repeating characters in them are "a", "b", "a", "c", "ab", "ba", "ac", and "bac". Note that "aba" and "abac" do
    not qualify because the character a'is repeated in them. Also note that two substrings, "a" and "a", both qualify because their start
    indices are different: s[0] and s[2]. There are 8 substrings that have no repeating characters.
    Function Description
    Complete the function findSubstrings in the editor below.
    findSubstrings has the following parameter:
    string s: the given string
    Returns
    int: the number of substrings in s that have no repeating characters
    Constraints
    1 ≤ length of ss 105
    s consists of only lowercase English letters, ascii['a'-'z'].

    ▾ Sample Case 0
    Sample Input For Custom Testing
    bcada
    Sample Output
    12
    Explanation
    There are 12 substrings in "bcada" that have no repeating characters: "b", "c", "a", "d", "a", "bc", "ca", "ad", "da", "bca", "cad", and "bcad".
    */
    public class SubstringSearch
    {
        public static int substringCount(string str)
        {
            if (str.Length == 0)
                return 0;
            else if (str.Length == 1)
                return 1;

            var result = new List<string>();
            var sub = "";

            for (int i = 0; i < str.Length; i++)
            {
                sub += str[i].ToString();
                result.Add(sub);
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (sub.Contains(str[j]))
                        break;
                    sub += str[j].ToString();
                    result.Add(sub);
                }
                sub = "";
            }

            return result.Count;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(substringCount("abac"));
            Console.Read();
        }
    }
}