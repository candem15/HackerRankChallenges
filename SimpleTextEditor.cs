using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestConsoleApp
{
    /*
    Implement a simple text editor. The editor initially contains an empty string, S.
    Perform Q operations of the following 4 types:

    1.append (W)- Append string W to the end of S.
    2.delete (k)- Delete the last k characters of S.
    3.print (k)- Print the k^th character of S.
    4.undo ()- Undo the last (not previously undone) operation of type 1 or 2,
    reverting S to the state it was in prior to that operation.

    Example

    operation
    index   S       ops[index]  explanation
    -----   ------  ----------  -----------
    0       abcde   1 fg        append fg
    1       abcdefg 3 6         print the 6th letter - f
    2       abcdefg 2 5         delete the last 5 letters
    3       ab      4           undo the last operation, index 2
    4       abcdefg 3 7         print the 7th characgter - g
    5       abcdefg 4           undo the last operation, index 0
    6       abcde   3 4         print the 4th character - d

    The results should be printed as:

    f
    g
    d

    Sample Input

    STDIN   Function
    -----   --------
    8       Q = 8
    1 abc   ops[0] = '1 abc'
    3 3     ops[1] = '3 3'
    2 3     ...
    1 xy
    3 2
    4
    4
    3 1

    Sample Output

    c
    y
    a
    */
    class SimpleTextEditor
    {
        static void Main(String[] args)
        {
            var numOfOperations = int.Parse(Console.ReadLine());
            var s = new StringBuilder();
            var sbOutput = new StringBuilder();
            var stringStack = new Stack<string>();

            for (int i = 0; i < numOfOperations; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                string command = arr[0];
                if (command == "1")
                {
                    stringStack.Push(s.ToString());
                    s.Append(arr[1]);
                }
                else if (command == "2")
                {
                    stringStack.Push(s.ToString());
                    var k = int.Parse(arr[1]);
                    s.Remove(s.Length - k, k);
                }
                else if (command == "3")
                {
                    var k = int.Parse(arr[1]);
                    sbOutput.Append(s[k - 1] + "\n");
                }
                else if (command == "4")
                {
                    s = new StringBuilder(stringStack.Pop());
                }
            }

            Console.Write(sbOutput.ToString());
        }
    }
}