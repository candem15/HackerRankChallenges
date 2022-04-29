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

    /* Bigger Is Greater

    Lexicographical order is often known as alphabetical order when dealing with strings.
    A string is greater than another string if it comes later in a lexicographically sorted list.

    Given a word, create a new word by swapping some or all of its characters.
    This new word must meet two criteria:

    It must be greater than the original word
    It must be the smallest word that meets the first condition.


    Sample Input 0

    5
    ab
    bb
    hefg
    dhck
    dkhc

    Sample Output 0

    ba
    no answer
    hegf
    dhkc
    hcdk
    */
    class BiggerIsGreater
    {

        /*
         * Complete the 'biggerIsGreater' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING w as parameter.
         */

        public static string biggerIsGreater(string w)
        {
            List<char> test = new List<char>();
            foreach (char c in w)
            {
                test.Add(c);
            }
            string result = "";
            char temp = ' ';
            char temp2 = ' ';
            int lastPosition = 0, changePoint = 0;
            for (int i = test.Count - 1; i > 0; i--)
            {
                if (test[i] > test[i - 1])
                {
                    temp = test[i - 1];
                    temp2 = test[i];
                    for (int j = test.Count - 1; j > i - 1; j--)
                    {
                        if (test[j] > temp && test[j] < temp2)
                        {
                            temp2 = test[j];
                            lastPosition = j;
                        }
                    }
                    test[i - 1] = temp2;
                    if (lastPosition == 0)
                        test[i] = temp;
                    else
                        test[lastPosition] = temp;
                    changePoint = i;
                    break;
                }
            }
            if (((test.Count - 1) - changePoint) > 0 && changePoint != 0)
            {
                List<char> test2 = new List<char>();
                for (int i = changePoint; i < test.Count; i++)
                {
                    test2.Add(test[i]);
                }
                test2.Sort();
                for (int i = 0; i < test2.Count; i++)
                {
                    test[changePoint] = test2[i];
                    changePoint++;
                }
            }
            foreach (var item in test)
            {
                result += item;
            }
            if (result == w)
                return "no answer";
            return result;
        }

        public static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine().Trim());

            for (int TItr = 0; TItr < T; TItr++)
            {
                string w = Console.ReadLine();

                string result = BiggerIsGreater.biggerIsGreater(w);

                Console.WriteLine(result);
            }

        }
    }
}