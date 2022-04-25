using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /*
    Given an array of integers, sort the array in ascending order using the Bubble Sort algorithm above.
    Once sorted, print the following three lines:

    Array is sorted in numSwaps swaps., where numSwaps is the number of swaps that took place.
    First Element: firstElement, where firstElement is the first element in the sorted array.
    Last Element: lastElement, where lastElement is the last element in the sorted array.

    Example:

    swap    a
    0       [6,4,1]
    1       [4,6,1]
    2       [4,1,6]
    3       [1,4,6]
    The steps of the bubble sort are shown above. It took  swaps to sort the array.

    Output is:

    Array is sorted in 3 swaps.
    First Element: 1
    Last Element: 6
    */
    public class SortingBubbleSort
    {
        public static void countSwaps(List<int> a)
        {
            int swap = 0, temp = 0;
            for (int write = 0; write < a.Count; write++)
            {
                for (int sort = 0; sort < a.Count - 1; sort++)
                {
                    if (a[sort] > a[sort + 1])
                    {
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                        swap++;
                    }
                }
            }
            Console.WriteLine($"Array is sorted in {swap} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Count - 1]}");
        }
        public static void Main(string[] args)
        {
            List<int> a = new List<int> { 6, 4, 1 };

            countSwaps(a);
        }
    }
}