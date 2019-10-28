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

}
