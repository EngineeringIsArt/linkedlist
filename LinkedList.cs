namespace linkedlist
{
    class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Find(T value)
        {
            var cursor = Head;
            while (cursor != null)
            {
                if (cursor.Value.Equals(value))
                {
                    break;
                }
                cursor = cursor.Next;
            }

            return cursor;
        }

        public void Add(T value)
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
        
        public void InsertAfter(T value, Node<T> target)
        {
            var node = new Node<T>(value);
            node.Next = target.Next;
            target.Next = node;
        }

        public void Remove(T value)
        {
            Node<T> previous = null;
            Node<T> cursor = Head;

            if (Head.Value.Equals(value))
            {
                Head = Head.Next;
                cursor.Next = null;
                return;
            }

            while (cursor != null)
            {                
                if (cursor.Value.Equals(value))
                {
                    previous.Next = cursor.Next;
                    cursor.Next = null;
                    return;
                }

                // Move cursor ahead
                previous = cursor;
                cursor = cursor.Next;
            }

        }
    }
}