namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new Node<int>(1);
            head.Next = new Node<int>(2);
            head.Next.Next = new Node<int>(3);
            Node<int>.PrintList(head);

            head = Node<int>.Reverse(head);
            Node<int>.PrintList(head);

            head = Node<int>.ReverseUsingStack(head);
            Node<int>.PrintList(head);
        }
    }

}
