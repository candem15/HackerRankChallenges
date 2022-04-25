using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class DuplicateProducts
    {
        /* Duplicate Products
        */
        public static int numDuplicates(List<string> name, List<int> price, List<int> weight)
        {
            var dummy = new List<string>();
            for (int i = 0; i < name.Count; i++)
            {
                dummy.Add(name[i] + " " + price[i].ToString() + " " + weight[i].ToString());
            }
            var hashSet = new HashSet<string>(dummy);
            return dummy.Count - hashSet.Count;
        }
    }
}