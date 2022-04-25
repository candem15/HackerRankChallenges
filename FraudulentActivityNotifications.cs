using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class FraudulentActivityNotifications
    {
        public static int activityNotifications(List<int> expenditure, int d)
        {
            var median = new List<int>();
            int notif = 0;
            for (int i = d; i < expenditure.Count; i++)
            {
                median = expenditure.GetRange(i - d, d);
                median.Sort();
                if (d % 2 == 0 && (expenditure[i] >= ((median[d / 2] + median[(d / 2) + 1]) / 2) * 2))
                {
                    notif++;
                }
                else if (expenditure[i] >= (median[(d / 2)]) * 2)
                {
                    notif++;
                }
            }
            return notif;
        }
        public static void Main(string[] args)
        {
            List<int> expenditure = new List<int> { 10, 20, 30, 40, 50 };

            Console.WriteLine(activityNotifications(expenditure, 3));
        }
    }
}