using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Sparse Arrays

    There is a collection of input strings and a collection of query strings.
    For each query string, determine how many times it occurs in the list of input strings.
    Return an array of the results.

        Sample Input 1

        Array: strings
        aba
        baba
        aba
        xzxb

        Array: queries
        aba
        xzxb
        ab

        Sample Output 1

        2 (aba occurs 2 times in strings)
        1 (xzxb occurs 2 times in strings)
        0 (ab occurs 0 in strings)
    */
    public class SparseArrays
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> numberOfOccurance = new List<int>();
            int count = 0;
            foreach (var item in queries)
            {
                count = strings.Where(x=>x.Equals(item)).Count();
                numberOfOccurance.Add(count);
            }
            return numberOfOccurance;
        }

        public static void Main(string[] args)
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = matchingStrings(strings, queries);

            Console.WriteLine(String.Join("\n", res));
            Console.Read();

        }
    }
}

