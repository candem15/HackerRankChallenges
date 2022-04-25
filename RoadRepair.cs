using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class RoadRepairResult
    {

        /*
         * Complete the 'getMinCost' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY crew_id
         *  2. INTEGER_ARRAY job_id
         */

        public static long getMinCost(List<int> crew_id, List<int> job_id)
        {
            int totalDistance=0;
            int distance = Math.Abs(job_id[0]-crew_id[0]);
            int jobIncrement=0;
            int jobIncrementTemp=0;
            for (int i = 0; i < job_id.Count; i++)
            {
                for ( ;jobIncrement < crew_id.Count; jobIncrement++)
                {
                    if(Math.Abs(job_id[i]-crew_id[jobIncrement])<distance)
                    {
                        distance=Math.Abs(job_id[i]-crew_id[jobIncrement]);
                        jobIncrementTemp=jobIncrement;
                    }
                }
                totalDistance+=distance;
                jobIncrement=0;
                crew_id.Remove(crew_id[jobIncrementTemp]);
            }

            return totalDistance;
        }

    }
    public class RoadRepair
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int crew_idCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> crew_id = new List<int>();

            for (int i = 0; i < crew_idCount; i++)
            {
                int crew_idItem = Convert.ToInt32(Console.ReadLine().Trim());
                crew_id.Add(crew_idItem);
            }

            int job_idCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> job_id = new List<int>();

            for (int i = 0; i < job_idCount; i++)
            {
                int job_idItem = Convert.ToInt32(Console.ReadLine().Trim());
                job_id.Add(job_idItem);
            }

            long result = RoadRepairResult.getMinCost(crew_id, job_id);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}