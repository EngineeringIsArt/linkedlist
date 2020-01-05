using System;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListStuff();
            //StackStuff();
            //QueueStuff();
            DoublyLinkedListStuff();
        }

        static void ListStuff()
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

        static void StackStuff()
        {
            var stack = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
        
        static void QueueStuff()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(4);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }

        static void DoublyLinkedListStuff()
        {
            var doubleList = new DoublyLinkedList<int>();
            doubleList.Append(2);
            doubleList.Append(3);
            doubleList.Append(4);
            doubleList.Prepend(1);

            doubleList.PrintList();
        }
    }

}
