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

        public static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.Write($"{node.Value} -> ");
                node = node.Next;
            }
        }
    }
}
