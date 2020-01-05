using System;

namespace linkedlist
{
    class DoublyLinkedList<T>
    {
        DoublyLinkedNode<T> Head { get; set; }
        DoublyLinkedNode<T> Tail { get; set; }

        public DoublyLinkedList()
        {
            Head = Tail = null;
        }

        public void Append(T value)
        {
            var node = new DoublyLinkedNode<T>(value);

            if (Head == null && Tail == null)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }
        }

        public void Prepend(T value)
        {
            var node = new DoublyLinkedNode<T>(value);

            if (Head == null && Tail == null)
            {
                Head = Tail = node;
            }
            else
            {
                Head.Previous = node;
                node.Next = Head;
                Head = node;
            }
        }

        public void PrintList()
        {
            var cursor = Head;

            while (cursor != null)
            {
                Console.WriteLine(cursor.Value);
                cursor = cursor.Next;
            }
        }
    }
}