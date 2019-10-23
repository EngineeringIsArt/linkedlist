using System;
using System.Collections.Generic;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            Node.PrintList(head);

            head = Node.Reverse(head);
            Node.PrintList(head);

            head = Node.ReverseUsingStack(head);
            Node.PrintList(head);
        }
    }

    class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public Node Next { get; set; }

        public static Node Reverse(Node head)
        {
            Node previous = null; // Seed null to change first node to last node.
            Node cursor = head;
            Node following;

            while (cursor != null)
            {
                // Store node ahead of following.
                following = cursor.Next;
                // Point following node's link to previous node.
                cursor.Next = previous;
                // Move cursor ahead
                previous = cursor;
                cursor = following;
            }

            return previous;
        }

        public static Node ReverseUsingStack(Node head)
        {
            var stack = new Stack<Node>();
            var cursor = head;

            while (cursor != null)
            {
                stack.Push(cursor);
                cursor = cursor.Next;
            }

            head = stack.Pop();
            cursor = head;

            do
            {
                cursor.Next = stack.Peek();
                cursor = stack.Pop();
            }
            while (stack.Count > 0);

            cursor.Next = null;

            return head;
        }

        public static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.Write($"{node.Value} -> ");
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
