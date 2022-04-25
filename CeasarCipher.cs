using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Ceasar Cipher

    Julius Caesar protected his confidential information by encrypting it using a cipher.
    Caesar's cipher shifts each letter by a number of letters. If the shift takes you past
    the end of the alphabet, just rotate back to the front of the alphabet. In the case of a
    rotation by 3, w, x, y and z would map to z, a, b and c.

    */
    public class CeasarCipher
    {
        public static string caesarCipher(string s, int k)
        {
            var alp = "abcdefghijklmnopqrstuvwxyz";
            var alp2 = alp.ToUpper();
            var result = "";
            while (k > 26)
            {
                k = k - 26;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (alp.Contains(s[i]))
                {
                    for (int j = 0; j < alp.Length; j++)
                    {
                        if (alp[j] == s[i])
                        {
                            if (k + j >= 26)
                            {
                                result += alp[k + j - 26];
                            }
                            else
                                result += alp[k + j];
                        }
                    }
                }
                else if (alp2.Contains(s[i]))
                {
                    for (int j = 0; j < alp2.Length; j++)
                    {
                        if (alp2[j] == s[i])
                        {
                            if (k + j >= 26)
                            {
                                result += alp2[k + j - 26];
                            }
                            else
                                result += alp2[k + j];
                        }
                    }
                }
                else
                    result += s[i];
            }
            return result;
        }

        public static void Main(string[] args)
        {
            string result = caesarCipher("Hello_World!", 4);

            Console.WriteLine(result);
        }
    }
}