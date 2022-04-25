using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class BalancedSystemFilesPartitionResult
    {

        /*
         * Complete the 'mostBalancedPartition' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY parent
         *  2. INTEGER_ARRAY files_size
         */

        public static int mostBalancedPartition(List<int> parent, List<int> files_size)
        {
            return 1;
        }

    }
    public class BalancedSystemFilesPartition
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int parentCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> parent = new List<int>();

            for (int i = 0; i < parentCount; i++)
            {
                int parentItem = Convert.ToInt32(Console.ReadLine().Trim());
                parent.Add(parentItem);
            }

            int files_sizeCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> files_size = new List<int>();

            for (int i = 0; i < files_sizeCount; i++)
            {
                int files_sizeItem = Convert.ToInt32(Console.ReadLine().Trim());
                files_size.Add(files_sizeItem);
            }

            int result = BalancedSystemFilesPartitionResult.mostBalancedPartition(parent, files_size);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}