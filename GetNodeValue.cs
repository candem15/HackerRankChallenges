using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace TestConsoleApp
{
    /* Get Node Value

    Given a pointer to the head of a linked list and a specific position, determine the data value at that position.
    Count backwards from the tail node. The tail is at postion 0, its parent is at 1 and so on.

    Sample Input

    2 (number of test case)
    1
    1 (position from tail)
    0
    3
    3
    2
    1
    2 (position from tail)

    Sample Output

    1
    3

    Explanation

    In the first case, there is one element in linked list with a value of 1. The last (only) element contains 1.

    In the second case, the list is 3->2->1->NULL. The element with position of 2 from tail contains 3.
    */
    class GetNodeValue
    {

        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }



        /*
         * Complete the 'getNode' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_SINGLY_LINKED_LIST llist
         *  2. INTEGER positionFromTail
         */

        /*
         * For your reference:
         *
         * SinglyLinkedListNode
         * {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */

        static int getNode(SinglyLinkedListNode llist, int positionFromTail)
        {
            SinglyLinkedListNode newNode = llist;
            List<int> numbers = new List<int>();
            while (newNode != null)
            {
                numbers.Add(newNode.data);
                newNode = newNode.next;
            }
            numbers.Reverse();

            return numbers[positionFromTail];
        }



        static void Main(string[] args)
        {
            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                int position = Convert.ToInt32(Console.ReadLine());

                int result = getNode(llist.head, position);

                Console.WriteLine(result);
            }
            Console.Read();
        }
    }
}