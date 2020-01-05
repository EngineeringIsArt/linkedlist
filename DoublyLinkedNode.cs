namespace linkedlist
{
    class DoublyLinkedNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedNode<T> Previous { get; set; }
        public DoublyLinkedNode<T> Next { get; set; }

        public DoublyLinkedNode(T value)
        {
            Value = value;
        }
    }
}