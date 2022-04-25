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
    /* Insert A Node At The Tail Of A Linked List

    Sample Input

    STDIN Function ----- -------- 5 size of linked list n = 5 141 linked list data values 141 474 302 164 530 474

    Sample Output

    141
    302
    164
    530
    474

    Explanation

    First the linked list is NULL. After inserting 141, the list is 141 -> NULL.
    After inserting 302, the list is 141 -> 302 -> NULL.
    After inserting 164, the list is 141 -> 302 -> 164 -> NULL.
    After inserting 530, the list is 141 -> 302 -> 164 -> 530 -> NULL.
    After inserting 474, the list is 141 -> 302 -> 164 -> 530 -> 474 -> NULL, which is the final list.
    */
    class InsertANodeAtTheTailOfALinkedList
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

            public SinglyLinkedList()
            {
                this.head = null;
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
        // Complete the insertNodeAtTail function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode(data);
            if (head == null)
            {
                head = new_node;
            }
            else
            {
                SinglyLinkedListNode currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = new_node;
            }
            return head;
        }

        static void Main(string[] args)
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
                llist.head = llist_head;
                Console.WriteLine(llist.head);
            }
        }
    }
}