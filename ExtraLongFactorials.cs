using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace TestConsoleApp
{
    /* Extra Long Factorials

    Calculate and print the factorial of a given integer.

    Constraints
    1<=n<=100

    Sample Input

    25

    Sample Output

    15511210043330985984000000

    */
    class ExtraLongFactorials
    {

        /*
         * Complete the 'extraLongFactorials' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void extraLongFactorials(int n)
        {

        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            ExtraLongFactorials.extraLongFactorials(n);
        }
    }
}
