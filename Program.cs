using System;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new Node<int>(1);
            head.Next = new Node<int>(2);
            head.Next.Next = new Node<int>(3);
            head.PrintList();

            head = head.Reverse();
            head.PrintList();

            head = head.ReverseUsingStack();
            head.PrintList();

            var list = new LinkedList<int>();
            list.Add(0);
            list.Head.PrintList();
            list.InsertAfter(88, list.Head);
            list.Head.PrintList();

            list.Head.Next.Next = head;
            list.Head.PrintList();
            var node = list.Find(1);
            Console.WriteLine(node.Value);

            list.Remove(2);
            list.Head.PrintList();
            list.Remove(0);
            list.Head.PrintList();
        }
    }

}
