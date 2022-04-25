using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Mark and Toys

    Mark and Jane are very happy after having their first child.
    Their son loves toys, so Mark wants to buy some.
    There are a number of different toys lying in front of him,
    tagged with their prices. Mark has only a certain amount to spend,
    and he wants to maximize the number of toys he buys with this money.
    Given a list of toy prices and an amount to spend, determine the maximum number of gifts he can buy.

    Note: Each toy can be purchased only once.
    */
    public class MarkAndToys
    {
        public static int maximumToys(List<int> prices, int k)
        {
            prices.Sort();
            int toyCount = 0;
            foreach (var toy in prices)
            {
                if (toy <= k)
                {
                    k-=toy;
                    toyCount++;
                }
            }
            return toyCount;
        }
        public static void Main(string[] args)
        {
            List<int> prices = new List<int> { 1, 12, 5, 111, 200, 1000, 10 };

            int result = maximumToys(prices, 50);

            Console.WriteLine(result);
        }
    }
}