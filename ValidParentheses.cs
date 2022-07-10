using System;
using System.Collections;
using System.Collections.Generic;

namespace TestConsoleApp
{
    /* Valid Parentheses

    Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.

    Example 1:
    Input: s = "()"
    Output: true

    Example 2:
    Input: s = "()[]{}"
    Output: true

    Example 3:
    Input: s = "(]"
    Output: false
    */
    public class ValidParentheses
    {
        public static void Main(string[] args)
        {
            var obj = new ValidParentheses();
            Console.WriteLine(obj.IsValid("()[]{}"));
        }

        public bool IsValid(string s)
        {
            try
            {
                Stack<char> stck = new();
                if (s.Length % 2 != 0)
                    return false;
                foreach (var item in s)
                {
                    if (item == '{' || item == '(' || item == '[')
                    {
                        stck.Push(item);
                    }
                    else if (item == '}' & stck.Peek() == '{')
                    {
                        stck.Pop();
                    }
                    else if (item == ']' & stck.Peek() == '[')
                    {
                        stck.Pop();
                    }
                    else if (item == ')' & stck.Peek() == '(')
                    {
                        stck.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                if (stck.Count == 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
