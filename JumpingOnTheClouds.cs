using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Jumping On The Clouds

    There is a new mobile game that starts with consecutively numbered clouds.
    Some of the clouds are thunderheads and others are cumulus.
    The player can jump on any cumulus cloud having a number
    that is equal to the number of the current cloud plus 1 or 2.
    The player must avoid the thunderheads. Determine the minimum
    number of jumps it will take to jump from the starting
    postion to the last cloud. It is always possible to win the game.

    For each game, you will get an array of clouds numbered 0
    if they are safe or 1 if they must be avoided.

    Sample Input:
    7
    0 0 1 0 0 1 0

    Sample Output:
    4
    */
    public class JumpingOnTheClouds
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int jumpCount = 0;
            for (int i = 0; i < c.Count; i++)
            {
                if (i + 2 < c.Count && c[i + 2] != 1)
                {
                    i++;
                    jumpCount++;
                }
                else if (i != c.Count - 1) jumpCount++;
            }
            return jumpCount;
        }

        public static void Main(string[] args)
        {
            List<int> c = new List<int> { 0, 0, 1, 0, 0, 1, 0 };

            int result = jumpingOnClouds(c);
            Console.WriteLine(result);
        }
    }
}