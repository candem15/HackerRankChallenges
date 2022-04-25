using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Sales By Match

    There is a large pile of socks that must be paired by color.
    Given an array of integers representing the color of each sock,
    determine how many pairs of socks with matching colors there are.

    Example
    N=7
    arr={1,2,1,2,3,2}

    There is one pair of color 1 and one of color 2.
    There are three odd socks left, one of each color.
    The number of pairs is 2.
    */
    public class SalesByMatch
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            var odds = new HashSet<int>();
            int pairsCount = 0;
            foreach (var item in ar)
            {
                if (odds.Contains(item))
                {
                    odds.Remove(item);
                    pairsCount++;
                }
                else
                {
                    odds.Add(item);
                }
            }
            return pairsCount;
        }

        public static void Main(string[] args)
        {

            List<int> ar = new List<int> { 1, 2, 1, 2, 3, 2 };

            int result = sockMerchant(7, ar);
        }
    }
}