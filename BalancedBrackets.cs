using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    /* Balanced Brackets
    Sample Input

    STDIN Function ----- -------- n = 3
    first query = '{[()]}'
    second query = '{[(])}'
    third query ='{{[[(())]]}}'

    Sample Output

    YES
    NO
    YES
    */
    public class BalancedBrackets
    {
        public static string isBalanced(string s)
        {
            var stack = new Stack<int>();
            var arr = new[] { '{', '(', '[', '}', ')', ']' };

            var idx = 0;
            foreach (var c in s)
            {
                idx = Array.IndexOf(arr, c);

                if (idx == -1) continue;

                if (idx < 3)
                {
                    stack.Push(idx);
                    continue;
                }

                if (stack.Count == 0 || stack.Pop() != (idx - 3))
                    return "NO";
            }

            return stack.Count == 0 ? "YES" : "NO";
        }
        public static void Main(string[] args)
        {
            int t = 1;

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = "()[{()}][][()]()(){}[]([[(){}]{([()])({})}])[()]([]{}([]{}({}())){()}{}())(())(())[()[()][({{[]}[([])()[{[]{}}(()({[{}](){}{{[]}{[]()}}}[]))[[]]][{[]((([])){})()()}]]})[()]]]()[{[][]}][{}[]][]({{()()[]}})[]()[{{}}](())((){{}{[]}}){}{[[]{{}()((){}([]){()(){{}{((({}{})[](){}({[{{()}{[[]][]}[[[]]{}]{}}([{{}[{{}}[]]{}[({}[]){{}}]{}{({[]}{{}})[][]}}][{({})[][]({[{}]}({}()[[[[][{({}([[]])){([[][][([][(){{}[][]}])[]](()[[[]]]([{}]([]{(){}(({()()}{}))(()[([])]{}){}[{(({}()))}[{}({{([]{})[()]}})(({()}[]{[{[]{[]{}}[()([])]}][{}]{}})){{[]}{}[]{{}}[](([])[]){[[]{}{()}]{([{{}}])}}([(()())[]()]({}))}{}]]}[([{[][{}[]{}]}[]{}])]([()]{}{}{}({{()}([{}])}[][]))){{}{}[]}{}([]({}[][]{}))))[]]()[](())[[]]{}{[]{}(())}{{[({})[()]](){}}})}{()}}((([{{}{()}[]}{()}]({}))(){[]}{({}[]){}()}{}(){()[]}[{}][[][[{}]{[[]{}[]]{[]()}}]((()[()]{{({([({{()}[((([][]))){}][[((){{[{}]()}})(()([](())){[[]][[]()]})]][]}[]{{}})]{}){([](()[])[[]((()()))](()))}}({[{[()]}][()]([{[]{[]{([])([])()}}[]}])}))}}))]))]]]]))}])]})))}}})}]}";

                string result = isBalanced(s);

                Console.WriteLine(result);
            }
        }
    }
}