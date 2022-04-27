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

    /* Find Merge Point Of Two Lists

    Given pointers to the head nodes of 2 linked lists that merge together at some point,
    find the node where the two lists merge.
    The merge point is where both lists point to the same node, i.e. they reference the same memory location.
    It is guaranteed that the two head nodes will be different, and neither will be NULL.
    If the lists share a common node, return that node's data value.

    Note: After the merge point, both lists will share the same node pointers.

    Sample Input

    List 1 = 1->4->5->7->8 (length 5)
    List 1 = 9->10->7->8 (length 4)

    Sample Output

    Node 7's data value

    Solution Explanation

    Search head's of two list, if their heads pointing null value reassign them to other list.
    After reassign, merge point will be at same position to check and find.
    head1 = 1->4->5->7->8->9->10->7(merge point)->8 (length 9)
    head2 = 9->10->7->8->1->4->5->7(merge point)->8 (length 9)


    */
    class FindMergePointOfTwoLists
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

        // Complete the findMergeNode function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            SinglyLinkedListNode loop1 = head1;
            SinglyLinkedListNode loop2 = head2;
            while (loop1 != loop2)
            {
                if (loop1.next != null)
                    loop1 = loop1.next;
                else
                    loop1= head2;
                if (loop2.next != null)
                    loop2 = loop2.next;
                else
                    loop2 = head1;
            }
            return loop1.data;
        }

        static void Main(string[] args)
        {

            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                int index = Convert.ToInt32(Console.ReadLine());

                SinglyLinkedList llist1 = new SinglyLinkedList();

                int llist1Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist1Count; i++)
                {
                    int llist1Item = Convert.ToInt32(Console.ReadLine());
                    llist1.InsertNode(llist1Item);
                }

                SinglyLinkedList llist2 = new SinglyLinkedList();

                int llist2Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist2Count; i++)
                {
                    int llist2Item = Convert.ToInt32(Console.ReadLine());
                    llist2.InsertNode(llist2Item);
                }

                SinglyLinkedListNode ptr1 = llist1.head;
                SinglyLinkedListNode ptr2 = llist2.head;

                for (int i = 0; i < llist1Count; i++)
                {
                    if (i < index)
                    {
                        ptr1 = ptr1.next;
                    }
                }

                for (int i = 0; i < llist2Count; i++)
                {
                    if (i != llist2Count - 1)
                    {
                        ptr2 = ptr2.next;
                    }
                }

                ptr2.next = ptr1;

                int result = findMergeNode(llist1.head, llist2.head);

            }
        }
    }
}