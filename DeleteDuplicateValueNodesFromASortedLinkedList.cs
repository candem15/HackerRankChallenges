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
    /* Delete Duplicate Value Nodes From A Sorted Linked List

    You are given the pointer to the head node of a sorted linked list, where the data in the nodes is in ascending order.
    Delete nodes and return a sorted list with each distinct value in the original list.
    The given head pointer may be null indicating that the list is empty.

    Sample Input

    STDIN   Function
    -----   --------
    1       t = 1
    5       n = 5
    1       data values = 1, 2, 2, 3, 4
    2
    2
    3
    4

    Sample Output

    1 2 3 4

    Explanation

    The initial linked list is: 1->2->2->3->4->null.

    The final linked list is: 1->2->3->4->null.
    */
    class DeleteDuplicateValueNodesFromASortedLinkedList
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
         * Complete the 'removeDuplicates' function below.
         *
         * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
         * The function accepts INTEGER_SINGLY_LINKED_LIST llist as parameter.
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

        static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode llist)
        {
            SinglyLinkedListNode currentNode = llist;
            while (currentNode!=null&&currentNode.next!=null)
            {
                if(currentNode.data!=currentNode.next.data)
                    currentNode = currentNode.next;
                else
                {
                    SinglyLinkedListNode newNode = currentNode.next.next;
                    currentNode.next = newNode;
                }
            }
            return llist;
        }



        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                SinglyLinkedListNode llist1 = removeDuplicates(llist.head);
            }

        }
    }
}