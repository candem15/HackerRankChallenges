using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Max-Min Sum

    Given five positive integers, find the minimum and maximum values that can be calculated by
    summing exactly four of the five integers. Then print the respective minimum and maximum
    values as a single line of two space-separated long integers.

    Sample Input

    1 2 3 4 5

    Sample Output

    10 14

    */
    public class MiniMax_Sum
    {
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            long min=0,max=0;
            for (int i = 0; i < arr.Count; i++)
            {
                if(i<4)
                min+=arr[i];
                if(i!=0)
                max+=arr[i];
            }
            Console.WriteLine(min+" "+max);
        }
        public static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(5);
            arr.Add(9);
            arr.Add(11);
            arr.Add(19);
            miniMaxSum(arr);
        }
    }
}