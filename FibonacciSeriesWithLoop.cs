using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class FibonacciSeriesWithLoop
    {
        public static int FibonacciPositionValue(int position)
        {
            var arr = new List<int>();
            arr.Add(0);
            arr.Add(1);
            for (int i = 2; i <= position; i++)
            {
                arr.Add(arr[i-1]+arr[i-2]);
            }
            return arr[position];
        }
        public static int Fibo(int pos)
        {
            if(pos==1 || pos==2)return 1;
            return Fibo(pos-1)+Fibo(pos-2);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.UtcNow.Millisecond);
            Console.WriteLine(FibonacciPositionValue(30));
            Console.WriteLine(DateTime.UtcNow.Millisecond);
            Console.WriteLine(Fibo(30));
            Console.WriteLine(DateTime.UtcNow.Millisecond);
        }
    }
}