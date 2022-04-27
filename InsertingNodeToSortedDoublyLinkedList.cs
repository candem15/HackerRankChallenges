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
    /* Inserting Node To Sorted Doubly Linked List

    Given a reference to the head of a doubly-linked list and an integer, data,
    create a new DoublyLinkedListNode object having data value data and insert it at the proper location to maintain the sort.

    Example

    head refers to the list 1<->2<->4<->null

    Return a reference to the new list: 1<->2<->3<->4<->null.
    */
    class InsertingNodeToSortedDoublyLinkedList
    {

        class DoublyLinkedListNode
        {
            public int data;
            public DoublyLinkedListNode next;
            public DoublyLinkedListNode prev;

            public DoublyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
                this.prev = null;
            }
        }

        class DoublyLinkedList
        {
            public DoublyLinkedListNode head;
            public DoublyLinkedListNode tail;

            public DoublyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                    node.prev = this.tail;
                }

                this.tail = node;
            }
        }

        static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
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
         * Complete the 'sortedInsert' function below.
         *
         * The function is expected to return an INTEGER_DOUBLY_LINKED_LIST.
         * The function accepts following parameters:
         *  1. INTEGER_DOUBLY_LINKED_LIST llist
         *  2. INTEGER data
         */

        /*
         * For your reference:
         *
         * DoublyLinkedListNode
         * {
         *     int data;
         *     DoublyLinkedListNode next;
         *     DoublyLinkedListNode prev;
         * }
         *
         */

        static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode llist, int data)
        {
            if (llist == null)
            {
                llist = new DoublyLinkedListNode(data);
                return llist;
            }
            if (llist.data > data)
            {
                DoublyLinkedListNode firstNode = new DoublyLinkedListNode(data);
                firstNode.next = llist;
                return firstNode;
            }
            DoublyLinkedListNode currentNode = llist;
            while (currentNode != null)
            {
                if (currentNode.next == null)
                {
                    currentNode.next = new DoublyLinkedListNode(data);
                    return llist;
                }
                else if (currentNode.data <= data && currentNode.next.data >= data)
                {
                    DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);
                    newNode.next = currentNode.next;
                    currentNode.next = newNode;
                    return llist;
                }
                currentNode = currentNode.next;
            }
            return llist;
        }



        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                DoublyLinkedList llist = new DoublyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                int data = Convert.ToInt32(Console.ReadLine());

                DoublyLinkedListNode llist1 = sortedInsert(llist.head, data);

            }
        }
    }
}