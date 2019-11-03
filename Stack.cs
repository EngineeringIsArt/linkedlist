namespace linkedlist
{
    public class Stack<T>
    {
        private Node<T> Head { get; set; }

        public void Push(T value)
        {
            var node = new Node<T>(value);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public T Pop()
        {
            if (Head == null)
            {
                return default(T);
            }

            var node = Head;
            Head = Head.Next;

            node.Next = null;
            return node.Value;
        }
    }
}