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
    /* Compare The Triplets

    Alice and Bob each created one problem for HackerRank.
    A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories:
    problem clarity, originality, and difficulty.

    The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]),
    and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).

    The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

    If a[i] > b[i], then Alice is awarded 1 point.
    If a[i] < b[i], then Bob is awarded 1 point.
    If a[i] = b[i], then neither person receives a point.
    Comparison points is the total points a person earned.

    Given a and b, determine their respective comparison points.

    Sample Input 0

    5 6 7
    3 6 10

    Sample Output 0

    1 1
    */
    class CompareTheTriplets
    {

        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>(){0,0};
            for (int i = 0; i < 3; i++)
            {
                if(a[i]>b[i])
                    result[0]++;
                else if (a[i]<b[i])
                    result[1]++;
            }
            return result;
        }

        public static void Main(string[] args)
        {

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = CompareTheTriplets.compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));

        }
    }
}