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
    /* Insert A Node At A Specific Position In A Linked List
    Sample Input

    3 (item count in linked list)
    16 (item)
    13 (item)
    7 (item)
    1 (data to insert)
    2 (position of inserted data)

    Sample Output

    16 13 1 7

    Explanation

    The initial linked list is 16->13->7. Insert 1 at the position 2 which currently has 7 in it.
    The updated linked list is 16->13->1->7.
    */
    class InsertANodeAtASpecificPositionInALinkedList
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
         * Complete the 'insertNodeAtPosition' function below.
         *
         * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
         * The function accepts following parameters:
         *  1. INTEGER_SINGLY_LINKED_LIST llist
         *  2. INTEGER data
         *  3. INTEGER position
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

        static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            int currentPosition = 0;
            SinglyLinkedListNode currentNode = llist;
            while (currentPosition < position - 1)
            {
                currentNode = currentNode.next;
                currentPosition++;
            }
            newNode.next = currentNode.next;
            currentNode.next = newNode;
            return llist;
        }


        public static void Main(string[] args)
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int data = Convert.ToInt32(Console.ReadLine());

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

            Console.WriteLine(llist);
        }
    }
}