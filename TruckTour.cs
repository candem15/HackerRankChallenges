using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Truck Tour

    Suppose there is a circle. There are N petrol pumps on that circle.
    Petrol pumps are numbered 0 to N-1 (both inclusive).
    You have two pieces of information corresponding to each of the petrol pump:
    (1) the amount of petrol that particular petrol pump will give,
    and (2) the distance from that petrol pump to the next petrol pump.

    Initially, you have a tank of infinite capacity carrying no petrol.
    You can start the tour at any of the petrol pumps.
    Calculate the first point from where the truck will be able to complete the circle.
    Consider that the truck will stop at each of the petrol pumps.
    The truck will move one kilometer for each litre of the petrol.
    */
    public class TruckTour
    {
        public static int truckTour(List<List<int>> petrolpumps)
        {
            int truckTank = 0;
            int startpoint=0;
            for (int i = 0; i < petrolpumps.Count; i++)
            {
                if (truckTank + petrolpumps[i][0] < petrolpumps[i][1])
                {
                    truckTank=0;
                    startpoint=-1;
                }
                else
                {
                    truckTank+=petrolpumps[i][0]-petrolpumps[i][1];
                    if(truckTank>=0 && startpoint<0)
                    startpoint=i;
                }
            }
            return startpoint;
        }
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> petrolpumps = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                petrolpumps.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(petrolpumpsTemp => Convert.ToInt32(petrolpumpsTemp)).ToList());
            }

            int result = truckTour(petrolpumps);
        }
    }
}