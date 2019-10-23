using System;

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
            Node previous = null;
            Node following = head;
            Node key = null;

            while (following != null)
            {
                // Store node ahead of following.
                key = following.Next;
                // Point following node's link to previous node.
                following.Next = previous;
                // Move cursor ahead
                previous = following;
                following = key;
            }

            return previous;
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
