using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /*  Meal Delivery

    Snuke lives at position
    x on a number line. On this line, there are two stores
    A and
    B, respectively at position
    a and
    b, that offer food for delivery.

    Snuke decided to get food delivery from the closer of stores
    A and
    B. Find out which store is closer to Snuke's residence.

    Here, the distance between two points
    s and
    t on a number line is represented by
    ∣s−t∣.

    Constraints
    1≤x≤1000
    1≤a≤1000
    1≤b≤1000
    x,a and
    b are pairwise distinct.
    The distances between Snuke's residence and stores
    A and
    B are different.
    Input
    Input is given from Standard Input in the following format:

    x
    a
    b
    Output
    If store
    A is closer, print A; if store
    B is closer, print B.

    Sample Input 1
    Copy
    5 2 7
    Sample Output 1
    Copy
    B
    The distances between Snuke's residence and stores
    A and
    B are
    3 and
    2, respectively. Since store
    B is closer, print B.

    Sample Input 2
    Copy
    1 999 1000
    Sample Output 2
    Copy
    A
    */
    public class MealDelivery
    {
        public static string closestStore(int[] arr)
        {
            return Math.Abs(arr[0] - arr[1]) < Math.Abs(arr[0] - arr[2]) ? "A" : "B";
        }

        public static void Main(string[] args)
        {
            var arr = new int[3];
            arr[0] = 1; //Snuke position
            arr[1] = 999; //Store A position
            arr[2] = 1000; //Store B position

            Console.WriteLine(closestStore(arr));
            Console.Read();
        }
    }
}