using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class BitwiseAndResult
    {
        static bool isPowerOfTwo(int n)
        {
            return (int)(Math.Ceiling((Math.Log(n) / Math.Log(2))))
                  == (int)(Math.Floor(((Math.Log(n) / Math.Log(2)))));
        }
        public static long countPairs(List<int> arr)
        {
            int result = 0;
            foreach (var item1 in arr)
            {
                foreach (var item2 in arr)
                {
                    var bitwise= item1&item2;
                    if (isPowerOfTwo(bitwise))
                        result ++;
                }
            }
            return result;
        }
    }
    public class BitwiseAnd
    {
        public static void Main(string[] args)
        {
            int arrCount = 5;//Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = new List<int>();

            /*for (int i = 0; i < arrCount; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                arr.Add(arrItem);
            }*/
            arr.Add(10);
            arr.Add(7);
            arr.Add(2);
            arr.Add(8);
            arr.Add(3);
            long result = BitwiseAndResult.countPairs(arr);
            Console.WriteLine(result);
        }
    }
}