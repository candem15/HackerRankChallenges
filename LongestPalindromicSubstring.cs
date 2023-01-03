using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsoleApp
{
    /* Longest Palindromic Substring

    Given a string s, return the longest palindromic substring in s.

    Example 1:
    Input: s = "babad"
    Output: "bab"
    Explanation: "aba" is also a valid answer.

    Example 2:
    Input: s = "cbbd"
    Output: "bb"
    */
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            string result = "";
            List<char> temp = new();
            List<char> reverse = new();
            for (int i = 0; i < s.Length; i++)
            {
                for (int ii = i; ii < s.Length; ii++)
                {
                    temp.Add(s[ii]);
                    reverse = new List<char>(temp);
                    reverse.Reverse();
                    if (new string(temp.ToArray()) == new string(reverse.ToArray()) & temp.Count > result.Length)
                    {
                        result = new string(temp.ToArray());
                    }
                }
                if (result.Length > s.Length - i)
                        break;
                temp = new();
            }
            return result;
        }
        public static void Main(string[] args)
        {
            var obj = new LongestPalindromicSubstring();
            Console.WriteLine(obj.LongestPalindrome("aaaa"));
        }
    }
}