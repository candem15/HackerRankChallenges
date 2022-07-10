using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Letter Combinations Of A Phone Number

    Given a string containing digits from 2-9 inclusive,
    return all possible letter combinations that the number could represent.
    Return the answer in any order.

    A mapping of digits to letters (just like on the telephone buttons) is given below.
    Note that 1 does not map to any letters.

    Example 1:
    Input: digits = "23"
    Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

    Example 2:
    Input: digits = ""
    Output: []

    Example 3:
    Input: digits = "2"
    Output: ["a","b","c"]
    */
    public class LetterCombinationsOfAPhoneNumber
    {
        Dictionary<char, List<char>> _map = new Dictionary<char, List<char>>(){
        {'2',new List<char>(){'a','b','c'}},
        {'3',new List<char>(){'d','e','f'}},
        {'4',new List<char>(){'g','h','i'}},
        {'5',new List<char>(){'j','k','l'}},
        {'6',new List<char>(){'m','n','o'}},
        {'7',new List<char>(){'p','q','r','s'}},
        {'8',new List<char>(){'t','u','v'}},
        {'9',new List<char>(){'w','x','y','z'}}
    };

        IList<string> result = new List<string>();
        public IList<string> LetterCombinations(string digits)
        {

            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }
            DFS(digits, 0, new List<char>());
            return result;
        }

        private void DFS(string digits, int level, List<char> current)
        {

            if (current.Count == digits.Length)
            {
                result.Add(new string(current.ToArray()));
                return;
            }

            foreach (var c in _map[digits[level]])
            {
                current.Add(c);
                DFS(digits, level + 1, current);
                current.RemoveAt(current.Count - 1);
            }

        }

        public static void Main(string[] args)
        {
            var obje = new LetterCombinationsOfAPhoneNumber();
            var result = obje.LetterCombinations("2355");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}