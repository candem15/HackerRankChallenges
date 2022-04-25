using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Counting Valleys

    An avid hiker keeps meticulous records of their hikes.
    During the last hike that took exactly steps steps,
    for every step it was noted if it was an uphill, U,
    or a downhill, D step. Hikes always start and end at sea level,
    and each step up or down represents a 1 unit change in altitude.
    We define the following terms:

    -A mountain is a sequence of consecutive steps above sea level,
    starting with a step up from sea level and ending with a step
    down to sea level.
    -A valley is a sequence of consecutive steps below sea level,
    starting with a step down from sea level and ending with a step up
    to sea level.

    Given the sequence of up and down steps during a hike,
    find and print the number of valleys walked through.
    */
    public class CountingValleys
    {
        public static int countingValleys(int steps, string path)
        {
            int valleyCount = 0, mountaingCount = 0, seaLevel = 0;
            foreach (char road in path)
            {
                if (road == 'D') seaLevel--;
                else seaLevel++;
                if (seaLevel == 0 && road == 'U') valleyCount++;
                else mountaingCount++;
            }
            return valleyCount;
        }

        public static void Main(string[] args)
        {
            int steps = 8;

            string path = "UDDDUDUU";

            int result = countingValleys(steps, path);
        }
    }
}