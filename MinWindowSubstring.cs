using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Have the function MinWindowSubstring(strArr) take the array of strings stored in strArr, which will contain only two strings, the first parameter being the string N and the second parameter being a string K of some characters, and your goal is to determine the smallest substring of N that contains all the characters in K. For example: if strArr is ["aaabaaddae", "aed"] then the smallest substring of N that contains the characters a, e, and d is "dae" located at the end of the string. So for this example your program should return the string dae.

    Another example: if strArr is ["aabdccdbcacd", "aad"] then the smallest substring of N that contains all of the characters in K is "aabd" which is located at the beginning of the string. Both parameters will be strings ranging in length from 1 to 50 characters and all of K's characters will exist somewhere in the string N. Both strings will only contains lowercase alphabetic characters.

    Examples
    Input: new string[] {"ahffaksfajeeubsne", "jefaa"}
    Output: aksfaje

    Input: new string[] {"aaffhkksemckelloe", "fhea"}
    Output: affhkkse
    */
    public class MinWindowSubstringMedium
    {
        public static string MinWindowSubs(string[] strArr)
        {
            if (strArr[0].Length < strArr[1].Length)
                return string.Empty;

            Dictionary<char, int> includeArr = new Dictionary<char, int>();
            foreach (char ch in strArr[1].Distinct())
            {
                includeArr.Add(ch, strArr[1].Count(x => x == ch));
            }
            int leftIndex = 0, rightIndex = strArr[0].Length;

            string resultString = strArr[0];
            bool leftcheck = false, rightcheck = false;
            while (!leftcheck)
            {
                var temp = strArr[0].Substring(leftIndex, rightIndex - leftIndex);
                foreach (var item in includeArr)
                {
                    if (temp.Count(x => x == item.Key) >= item.Value)
                    {

                    }
                    else
                    {
                        leftIndex -= 2;
                        leftcheck = true;
                    }
                }
                if (!leftcheck)
                    resultString = temp;
                leftIndex++;
            }

            while (!rightcheck)
            {
                if (leftIndex < 0)
                    leftIndex = 0;
                var temp = strArr[0].Substring(leftIndex, rightIndex - leftIndex);
                foreach (var item in includeArr)
                {
                    if (temp.Count(x => x == item.Key) >= item.Value)
                    {

                    }
                    else
                    {
                        rightIndex += 2;
                        rightcheck = true;
                    }
                }
                if (!rightcheck)
                    resultString = temp;
                rightIndex--;
            }

            return resultString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MinWindowSubs(new string[] { "aabdccdbcacd", "aad" }));
            Console.Read();
        }
    }
}