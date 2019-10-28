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
        }
    }

}
