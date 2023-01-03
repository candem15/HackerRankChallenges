using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Equal Stacks

    Find the maximum possible height of the stacks such that all of the stacks are exactly the same height.
    This means you must remove zero or more cylinders from the top of zero or more of the three stacks until
    they are all the same height, then return the height.

    Sample Input

    STDIN       Function
    -----       --------
    5 3 4       h1[] size n1 = 5, h2[] size n2 = 3, h3[] size n3 = 4
    3 2 1 1 1   h1 = [3, 2, 1, 1, 1] : 8
    4 3 2       h2 = [4, 3, 2] : 9
    1 1 4 1     h3 = [1, 1, 4, 1] : 7

    Sample Output

    5

    */
    public class EqualStacks
    {
        public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
        {
            long firstList = h1.GetRange(0, h1.Count).Sum();
            long secondList = h2.GetRange(0, h2.Count).Sum();
            long thirdList = h3.GetRange(0, h3.Count).Sum();
            while (!(firstList == secondList && secondList == thirdList && firstList == thirdList))
            {
                if (firstList == 0 || secondList == 0 || thirdList == 0)
                    return 0;
                if (firstList >= secondList && firstList >= thirdList)
                {
                    firstList -= h1[0];
                    h1.Remove(h1[0]);
                }
                else if (secondList >=firstList && secondList >=thirdList)
                {
                    secondList -= h2[0];
                    h2.Remove(h2[0]);
                }
                else
                {
                    thirdList -= h3[0];
                    h3.Remove(h3[0]);
                }
            }
            return (int)firstList;
        }

        public static void Main(string[] args)
        {
            List<int> h1 = new List<int>() { 3, 2, 1, 1, 1 };

            List<int> h2 = new List<int>() { 4, 3, 2 };

            List<int> h3 = new List<int>() { 1, 1, 4, 1 };

            int result = equalStacks(h1, h2, h3);

            Console.WriteLine(result);
            Console.Read();
        }
    }
}