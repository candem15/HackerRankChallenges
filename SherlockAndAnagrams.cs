using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Sherlock And Anagrams

    Two strings are anagrams of each other if
    the letters of one string can be rearranged
    to form the other string. Given a string,
    find the number of pairs of substrings of the string that are anagrams of each other.

    */
    public class SherlockAndAnagrams
    {
        static int sherlockAndAnagrams(string s)
        {
            var set = new Dictionary<string, int>();
            var cnt = 0;
            for (int len = 1; len <= s.Length - 1; len++)
                for (int i = 0; i <= s.Length - len; i++)
                {
                    var norm = new string(s.Substring(i, len).OrderBy(c => c).ToArray());
                    if (set.ContainsKey(norm))
                    {
                        cnt += set[norm];
                        set[norm] += 1;
                    }
                    else
                        set[norm] = 1;
                }
            return cnt;
        }

        public static void Main(string[] args)
        {
            int result = sherlockAndAnagrams("abba");

            Console.WriteLine(result);
        }
    }
}