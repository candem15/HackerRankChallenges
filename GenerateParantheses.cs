using System;

namespace TestConsoleApp
{
    /* Generate Parantheses

    For given lenght produce parantheses that builded with random generation. Parantheses must valid

    Correct example : "((()(())()))"
    Wrong one : "))))())()"

    For every open bracket there must be closing bracket exists.
    So if given lentgh is 16, there must be 8 opening 8 closing parantheses with random pattern.
    */
    public class GenerateParantheses
    {
        public static string Generate(int outputLength)
        {
            if (outputLength < 0)
                return "";

            outputLength = outputLength % 2 == 0 ? outputLength : outputLength += 1;
            int openingBracket = outputLength / 2, closingBracket = outputLength / 2;

            Random randomizer = new();

            string randomizedParantheses = "";

            while (randomizedParantheses.Length != outputLength)
            {
                if (openingBracket != 0 && randomizer.Next(0, 2) == 1)
                {
                    randomizedParantheses += '(';
                    openingBracket--;
                }
                if (closingBracket > openingBracket && randomizer.Next(0, 2) == 0)
                {
                    randomizedParantheses += ')';
                    closingBracket--;
                }
            }

            return randomizedParantheses;
        }
        public static void Main(string[] args)
        {

            Console.WriteLine(Generate(31));
            Console.Read();
        }
    }
}