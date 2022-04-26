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
    /* Cycle Dedection

    A linked list is said to contain a cycle if any node is visited more than once while traversing the list.
    Given a pointer to the head of a linked list, determine if it contains a cycle.
    If it does, return 1. Otherwise, return 0.

    Note: If the list is empty, head will be null.

    Sample Input

    References to each of the following linked lists are passed as arguments to your function:

    Sample Inputs

    1->null
    1->2->3->2

    Sample Output

    0
    1

    Explanation

    The first list has no cycle, so return 0.
    The second list has a cycle, so return 1.
    */
    class CycleDedection
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

        // Complete the hasCycle function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        static bool hasCycle(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode slowNode = head;
            SinglyLinkedListNode fastNode = head.next;
            while (slowNode != null && fastNode != null && fastNode.next != null)
            {
                if (slowNode == fastNode)
                    return true;
                else
                {
                    slowNode = slowNode.next;
                    fastNode = fastNode.next.next;
                }

            }
            return false;
        }

        static void Main(string[] args)
        {

            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                int index = Convert.ToInt32(Console.ReadLine());

                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                SinglyLinkedListNode extra = new SinglyLinkedListNode(-1);
                SinglyLinkedListNode temp = llist.head;

                for (int i = 0; i < llistCount; i++)
                {
                    if (i == index)
                    {
                        extra = temp;
                    }

                    if (i != llistCount - 1)
                    {
                        temp = temp.next;
                    }
                }

                temp.next = extra;

                bool result = hasCycle(llist.head);
                Console.WriteLine(result);
            }
            Console.Read();
        }
    }
}
