using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class PalindromeIndex
    {
        public static int palindromeIndex(string s)
        {
            int result = -1;
            int len = s.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (s[i] == s[len - 1 - i])
                    continue;
                else if (s[i + 1] == s[len - i - 1] && s[i + 2] == s[len - i - 2])
                    return i;
                else if (s[i] == s[len - i - 2] && s[i + 1] == s[len - i - 3])
                    return len - i - 1;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(palindromeIndex("abc211cba"));
        }
    }
}