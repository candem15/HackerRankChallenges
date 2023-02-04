using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class SumTwoStringTypeNumbers
    {
        public static string Sum(string val1, string val2)
        {
            if (val1.Length > val2.Length)
                val2 = val2.PadLeft(val1.Length, '0');
            else
                val1 = val1.PadLeft(val2.Length, '0');
            StringBuilder sb = new StringBuilder();
            byte leapVal = 0;
            for (int i = val1.Length - 1; i >= 0; i--)
            {
                byte sum = (byte)(Byte.Parse(val1[i].ToString()) + Byte.Parse(val2[i].ToString()) + leapVal);
                if (sum <= 9)
                {
                    sb = sb.Insert(0, sum.ToString());
                    leapVal = 0;
                    continue;
                }
                sb = sb.Insert(0, (sum % 10).ToString());
                leapVal = 1;
            }
            if (leapVal == 1)
                sb.Insert(0, 1);
            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Sum("8172893719874817283491738971987489179", "7236457812012937809217501983017401273980914091"));
        }
    }
}