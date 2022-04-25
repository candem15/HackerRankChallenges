using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Grid Challenge

    Given a square grid of characters in the range ascii[a-z],
    rearrange elements of each row alphabetically, ascending.
    Determine if the columns are also in ascending alphabetical order,
    top to bottom. Return YES if they are or NO if they are not.

    Example
    The grid is illustrated below.

    a b c
    a d e
    e f g
    The rows are already in alphabetical order.
    The columns a a e, b d f and c e g are also in alphabetical order,
    so the answer would be YES. Only elements within the same row can be rearranged.
    They cannot be moved to a different row.
    */
    public class GridChallenge
    {
        public static string gridChallenge(List<string> grid)
        {

            for (int i = 0; i < grid.Count; i++)
            {
                var temp = grid[i].ToCharArray();
                Array.Sort(temp);
                grid[i] = new string(temp);
            }
            for (int i = 0; i < grid.Count; i++)
            {
                for (int j = 0; j < grid.Count - 1; j++)
                {
                    if ((int)grid[j][i] > (int)grid[j + 1][i])
                        continue;
                    else return "NO";
                }
            }
            return "YES";
        }
        public static void Main(string[] args)
        {
            var list=new List<string>();
            list.Add("eibjbwsp");
            list.Add("ptfxehaq");
            list.Add("jxipvfga");
            list.Add("rkefiyub");
            list.Add("kalwfhfj");
            list.Add("lktajiaq");
            list.Add("srdgoros");
            list.Add("nflvjznh");

            string result = gridChallenge(list);
            Console.WriteLine(result);
        }
    }
}