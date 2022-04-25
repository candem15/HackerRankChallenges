using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestConsoleApp
{
    class QueryUsingTwoStacks{
    /* Queue Using Two Stacks
        A queue is an abstract data type that maintains the order in which elements were added to it,
        allowing the oldest elements to be removed from the front and new elements to be added to the rear.
        This is called a First-In-First-Out (FIFO) data structure because the first element added to the queue
        (i.e., the one that has been waiting the longest) is always the first one to be removed.

        A basic queue has the following operations:

        Enqueue: add a new element to the end of the queue.
        Dequeue: remove the element from the front of the queue and return it.
        In this challenge, you must first implement a queue using two stacks. Then process  queries, where each query is one of the following  types:

        1 x: Enqueue element  into the end of the queue.
        2: Dequeue the element at the front of the queue.
        3: Print the element at the front of the queue.

        Sample Input

        STDIN   Function
        -----   --------
        10      q = 10 (number of queries)
        1 42    1st query, enqueue 42
        2       dequeue front element
        1 14    enqueue 42
        3       print the front element
        1 28    enqueue 28
        3       print the front element
        1 60    enqueue 60
        1 78    enqueue 78
        2       dequeue front element
        2       dequeue front element

        Sample Output

        14
        14

        Explanation

        Perform the following sequence of actions:

        Enqueue 42; queue = {42}.
        Dequeue the value at the head of the queue, 42; queue = {}.
        Enqueue 14; queue = {14}.
        Print the value at the head of the queue, 14 ;queue = {14}.
        Enqueue 28; queue = {14,28}.
        Print the value at the head of the queue, 14; queue = {14,28}.
        Enqueue 60; queue = {14,28,60}.
        Enqueue 78; queue = {14,28,60,78}.
        Dequeue the value at the head of the queue, 14; {28,60,78}.
        Dequeue the value at the head of the queue, 28; {60,78}.
        */
    public class Node
    {
        public int Data;
    }

    public class Queue
    {
        Stack<Node> stack1;
        Stack<Node> stack2;

        public Queue()
        {
            stack1 = new Stack<Node>();
            stack2 = new Stack<Node>();
        }

        public void Enqueue(Node node)
        {
            stack1.Push(node);
        }

        public Node Dequeue()
        {
            if (stack2.Count != 0)
                return stack2.Pop();
            else
            {
                if (stack1.Count == 0) return null;
                while (stack1.Count > 0)
                    stack2.Push(stack1.Pop());
                return stack2.Pop();
            }
        }

        public void Print()
        {
            if (stack2.Count != 0)
                Console.WriteLine(stack2.Peek().Data);
            else
            {
                if (stack1.Count == 0)
                {
                    Console.WriteLine("-*empty*-");
                    return;
                }
                while (stack1.Count > 0)
                    stack2.Push(stack1.Pop());

                Console.WriteLine(stack2.Peek().Data);
            }
        }
    }

    static void Main(String[] args)
    {
        var queue = new Queue();
        var queryCount = int.Parse(Console.ReadLine());
        var query = new int[2];
        for (int i = 0; i < queryCount; i++)
        {
            query = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            switch (query[0])
            {
                case 1:
                    queue.Enqueue(new Node { Data = query[1] });
                    break;
                case 2:
                    queue.Dequeue();
                    break;
                case 3:
                    queue.Print();
                    break;
            }
        }
        return;
    }
}
}
