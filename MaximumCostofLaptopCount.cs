using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class MaximumCostofLaptopCountResult
    {
/*
Maximum Cost of Laptop Count

Accompany manufactures a fixed number of laptops every day. However, if some defect is encountered during the
testing of a laptop, it is labeled as “illegal” and is not counted in the laptop count of the day. Given the cost to
manufacture each laptop, its label as “illegal” or “legal”, and the number of legal laptops to be manufactured each
day, find the maximum cost incurred by the company in a single day in manufacturing all the laptops.

Note that if a laptop is labeled as illegal, its manufacturing cost is still incurred by the company, even though it is not
included in the laptop count. Also, days are only taken into when the daily laptop count has been completely met. If
there are no such days, the answer is 0.

For example, let's say there are n =5laptops, where cost = (2, 5, 3, 11, 1. The labels for these laptops are /abels =
flegal’, “illegal”, “legal”, “illegal”, “legal"l Finally, the dailyCount = 2, which means that the company needs to
manufacture 2 legal laptops each day. The queue of laptops can be more easily viewed as follows:


© cost 2, “legal”
© cost 5, “illegal”
© cost 3, “legal”
© cost 11, "illegal"
© cost 1, “legal”

On the first day, the first three laptops are manufactured in order to reach the daily count of 2 legal laptops. The cost incurred on
this day is 2 + 5 + 3= 10. On the secand day, the fourth and fifth laptops are manufactured, but because only one of them is legal,
the daily count isn't met, so that day is nat taken into consideration. Therefore, the maximum cost incurred on a single day is 10.

Function Description
Complete the function maxCostin the editor below.

maxCosthas the following parameters}:
int cost{n. an array of integers denoting the cost to manufacture each laptop
string labelsink an array of strings denoting the label of each laptop "legal! or ‘illegal")
int dailyCount: the number of legal laptops to be manufactured each day

Returns:
int: the maximum cost incurred in a single day of laptop manufacturing
*/

        /*
         * Complete the 'maxCost' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY cost
         *  2. STRING_ARRAY labels
         *  3. INTEGER dailyCount
         */
        public class laptops
        {
            public int Id { get; set; }
            public int cost { get; set; }
            public string labels { get; set; }
        }

        public static int maxCost(List<int> cost, List<string> labels, int dailyCount)
        {
            var laptops = new List<laptops>();
            var laptopId = 0;

            for (int i = 0; i < labels.Count; i++)
            {
                var laptop = new laptops() { Id = ++laptopId, cost = cost[i], labels = labels[i] };
                laptops.Add(laptop);
            }
            if (dailyCount > laptops.Count)
                return 0;
            var maxCost = 0;
            var currentCost = 0;
            var tempCost = 0;
            var currentCount = 0;
            foreach (var item in laptops)
            {
                if (currentCount < dailyCount)
                {
                    if (item.labels == "legal")
                    {
                        currentCost += item.cost;
                        currentCount++;
                    }
                    else
                    {
                        currentCost += item.cost;
                    }
                }
                if (currentCount == dailyCount)
                {
                    tempCost = currentCost;
                    currentCost = 0;
                    currentCount = 0;
                }
                if (maxCost < tempCost)
                {
                    maxCost = tempCost;
                }
            }
            return maxCost;
        }

    }
    public class MaximumCostofLaptopCount
    {
        public static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int costCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> cost = new List<int>();

            for (int i = 0; i < costCount; i++)
            {
                int costItem = Convert.ToInt32(Console.ReadLine().Trim());
                cost.Add(costItem);
            }

            int labelsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> labels = new List<string>();

            for (int i = 0; i < labelsCount; i++)
            {
                string labelsItem = Console.ReadLine();
                labels.Add(labelsItem);
            }

            int dailyCount = Convert.ToInt32(Console.ReadLine().Trim());

            int result = MaximumCostofLaptopCountResult.maxCost(cost, labels, dailyCount);
        }
    }
}