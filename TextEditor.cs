using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /*
    2. Text Editor
    In this task, a prototype for a text editor application is to be implemented consisting of the following functionalities:
    Command
    Action
    ["Insert", s]
    ["Print", x]
    ["Left", x]
    ["Right", x]
    ["Backspace", x]
    ["Delete", x]
    Given a 2-d array of strings size n x 2, commands, find the string obtained on each of the print operations by performing the above
    operations starting from an empty string and cursor at the starting position and report them as an array of printed strings in order. If
    for any operation the cursor reaches the beginning or the end of the current string, it does not go any further on the either side.
    Note: For consistency, the second argument is always provided as a string and hence might be required to be converted to an integer
    for the relevant commands.
    Command

    Example
    Suppose n = 6 and commands = [["Insert", "hello"], ["Left", "3"], ["Delete", "1"], ["Right", "2"], ["Backspace", "1"], ["Print", "4"]].
    Insert
    "hello"
    Left 3
    Delete 1
    Right 2
    Backspace 1
    Print 4
    ||||
    "hello"
    Insert the string at the current cursor position,
    the cursor will also move to the right by the length of the inserted string
    Current
    String
    "hello"
    If the cursor is at position m, print all the characters from m - xto m + X
    Move the cursor x positions to the left
    Move the cursor x positions to the right
    Remove x characters to the left of the cursor
    Remove x characters to the right of the cursor
    "helo"
    "helo"
    Hence the answer is ["hel"]
    in
    5
    2
    2
    4
    Current
    Cursor
    Final
    String
    "hello"
    "hello"
    "helo"
    "helo"
    "hel"
    Final
    Cursor
    5 (after o)
    2 (after e)
    2 (after e)
    4 (after o)
    3 (after I)
    Print
    Print characters from 3 - 4 to 3 + 4. Hence print
    "hel"
    */
    public class TextEditor
    {
        public static List<string> printTexts(List<List<string>> commands)
        {
            var cursor = 0;
            var currentStr = "";
            var result = new List<string>();
            for (int i = 0; i < commands.Count; i++)
            {
                switch (commands[i][0])
                {
                    case "Insert":
                        currentStr = currentStr.Insert(cursor, commands[i][1]);
                        cursor += commands[i][1].Length;
                        break;
                    case "Delete":
                        currentStr = currentStr.Remove(cursor, (currentStr.Length - (cursor + int.Parse(commands[i][1]))) <= 0 ? currentStr.Length - cursor : int.Parse(commands[i][1]));
                        if (cursor > currentStr.Length)
                            cursor = currentStr.Length;
                        break;
                    case "Right":
                        cursor = (cursor + int.Parse(commands[i][1])) >= currentStr.Length ? currentStr.Length : cursor + int.Parse(commands[i][1]);
                        break;
                    case "Left":
                        cursor = (cursor - int.Parse(commands[i][1])) >= 0 ? cursor - int.Parse(commands[i][1]) : 0;
                        break;
                    case "Backspace":
                        cursor = (cursor - int.Parse(commands[i][1])) < 0 ? 0 : (cursor - int.Parse(commands[i][1]));
                        if (cursor > int.Parse(commands[i][1]))
                            currentStr = currentStr.Remove(cursor, int.Parse(commands[i][1]));
                        break;
                    default:
                        var start = 0;
                        var end = 0;
                        if (cursor - int.Parse(commands[i][1]) <= 0)
                            start = 0;
                        else
                        {
                            start = cursor - int.Parse(commands[i][1]);
                        }
                        if (cursor + int.Parse(commands[i][1]) > currentStr.Length)
                            end = currentStr.Length;
                        else
                            end = cursor + int.Parse(commands[i][1]);
                        result.Add(currentStr.Substring(start, end));
                        break;
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            var commands = new List<List<string>>();
            commands.Add(new List<string> { "Insert", "hello" });
            commands.Add(new List<string> { "Left", "3" });
            commands.Add(new List<string> { "Delete", "1" });
            commands.Add(new List<string> { "Right", "2" });
            commands.Add(new List<string> { "Backspace", "1" });
            commands.Add(new List<string> { "Print", "4" });

            foreach (var item in printTexts(commands))
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}