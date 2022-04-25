using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Time Conversion

    Given a time in -hour AM/PM format, convert it to military (24-hour) time.

    Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
          - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
    Sample Input

    07:05:45PM

    Sample Output

    19:05:45
    */
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            var date = DateTime.Parse(s);
            return date.ToString("HH:mm:ss");
        }
        public static void Main(string[] args)
        {
            string s = "07:05:45PM";

            string result = timeConversion(s);

            Console.WriteLine(result);
        }
    }
}