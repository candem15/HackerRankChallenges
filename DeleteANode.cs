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
    /* Delet A Node

    Delete the node at a given position in a linked list and return a reference to the head node.
    The head is at position 0. The list may be empty after you delete the node.
    In that case, return a null value.

    Sample Input

    8 (number of nodes)
    20
    6
    2
    19
    7
    4
    15
    9
    3 (position to delete)

    Sample Output

    20 6 2 7 4 15 9

    Result = position 3 with data 19 deleted
    */
    class DeleteANode
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
         * Complete the 'deleteNode' function below.
         *
         * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
         * The function accepts following parameters:
         *  1. INTEGER_SINGLY_LINKED_LIST llist
         *  2. INTEGER position
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

        static SinglyLinkedListNode deleteNode(SinglyLinkedListNode llist, int position)
        {
            SinglyLinkedListNode currentNode = llist;
            int currentPosition = 0;
            if (position != 0)
            {
                while (currentPosition < position - 1)
                {
                    currentNode = currentNode.next;
                    currentPosition++;
                }
                currentNode.next = currentNode.next.next;
            }
            else
            {
                currentNode = currentNode.next;
                return currentNode;
            }

            return llist;
        }



        static void Main(string[] args)
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist1 = deleteNode(llist.head, position);
        }
    }
}