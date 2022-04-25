using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class CountTriplets
    {
        static long countTriplets(List<long> arr, long r)
        {
            long triplets = 0;
            foreach (var item in arr)
            {
                if (item % r != 0 && item != 1) arr.Remove(item);
            }
            for (int i = 0; i < arr.Count - 2; i++)
            {
                for (int j = i + 1; j < arr.Count - 1; j++)
                {
                    for (int k = j + 1; k < arr.Count; k++)
                    {
                        if (arr[i] * r == arr[j] && arr[j] * r == arr[k]) triplets++;
                    }
                }
            }
            return triplets;
        }

        static void Main(string[] args)
        {

            List<long> arr = new List<long> { 1, 2, 2, 4 };

            Console.WriteLine(countTriplets(arr, 2));
        }
    }
}