using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Entertech
    {
        public static void Main(string[] args)
        {
            int sayi1 = int.Parse(Console.ReadLine()), sayi2 = int.Parse(Console.ReadLine()), result = 0;
            while (sayi2 >= 1)
            {
                Console.WriteLine(sayi1 + " " + sayi2);
                if (sayi2 % 2 != 0)
                    result += sayi1;
                sayi1 *= 2;
                sayi2 /= 2;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}