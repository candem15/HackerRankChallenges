using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class MergeTwoSortedLinkedLists
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
        /* Merge Two Sorted Linked Lists

        Given pointers to the heads of two sorted linked lists, merge them into a single, s
        orted linked list. Either head pointer may be null meaning that the corresponding list is empty.

        Example
        HEAD-A refers to 1 3 7 null
        HEAD-B refers to 1 2 null

        The new list is 1 1 2 3 7 null
        */
        static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            if (head1 == null)
            {
                return head2;
            }
            if (head2 == null)
            {
                return head1;
            }

            if (head1.data < head2.data)
            {
                SinglyLinkedListNode nextSortedHead = mergeLists(head1.next, head2);
                head1.next = nextSortedHead;
                return head1;
            }
            else
            {
                SinglyLinkedListNode nextSortedHead = mergeLists(head1, head2.next);
                head2.next = nextSortedHead;
                return head2;
            }
        }

        static void Main(string[] args)
        {

            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
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

                SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);
            }
        }
    }
}