using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* New Year Chaos

    It is New Year's Day and people are in line for the Wonderland rollercoaster ride.
    Each person wears a sticker indicating their initial position in the queue from  to .
     Any person can bribe the person directly in front of them to swap positions,
     but they still wear their original sticker. One person can bribe at most two others.

    Determine the minimum number of bribes that took place to get to a given queue order.
    Print the number of bribes, or, if anyone has bribed more than two people, print Too chaotic.
        STDIN       Function
    -----       --------
    2           t = 2
    5           n = 5
    2 1 5 3 4   q = [2, 1, 5, 3, 4]
    5           n = 5
    2 5 1 3 4   q = [2, 5, 1, 3, 4]
    Sample Output

    3
    Too chaotic
    */
    public class NewYearChaos
    {
        public static void minimumBribes(List<int> q)
        {
            var list = new List<int>(q);
            list.Sort();
            int bribe = 0, temp = 0, len = q.Count;
        again:
            for (int i = 0; i < len; i++)
            {
                if (q[i] == i + 1)
                    continue;
                else if (q[i] != i + 2 && q[i] != i + 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                else if (q[i] < q[i + 1]) continue;
                else
                {
                    temp = q[i];
                    q[i] = q[i + 1];
                    q[i + 1] = temp;
                    bribe++;
                }
                if (q.SequenceEqual(list)) Console.WriteLine(bribe);
            }
            if (!q.SequenceEqual(list)) goto again;

        }

        public static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 5, 3, 4, 7, 8, 6 };

            minimumBribes(list);
        }
    }
}