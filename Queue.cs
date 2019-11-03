namespace linkedlist
{
    public class Queue<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }

        public void Enqueue(T value)
        {
            var node = new Node<T>(value);
            if (Head == null)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }

        public T Dequeue()
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