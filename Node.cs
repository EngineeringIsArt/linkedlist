using System;
using System.Collections.Generic;

class Node<T>
{
    public Node(T value)
    {
        Value = value;
    }

    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public static Node<T> Reverse(Node<T> head)
    {
        Node<T> previous = null; // Seed null to change first node to last node.
        Node<T> cursor = head;
        Node<T> following;

        while (cursor != null)
        {
            // Store node ahead of following.
            following = cursor.Next;
            // Point current node's link to previous node.
            cursor.Next = previous;
            // Move cursor ahead
            previous = cursor;
            cursor = following;
        }

        return previous;
    }

    public static Node<T> ReverseUsingStack(Node<T> head)
    {
        var stack = new Stack<Node<T>>();
        var cursor = head;

        while (cursor != null)
        {
            stack.Push(cursor);
            cursor = cursor.Next;
        }

        head = stack.Pop();
        cursor = head;
        do
        {
            cursor.Next = stack.Peek();
            cursor = stack.Pop();
        }
        while (stack.Count > 0);
        cursor.Next = null;

        return head;
    }

    public static void PrintList(Node<T> node)
    {
        while (node != null)
        {
            Console.Write($"{node.Value} -> ");
            node = node.Next;
        }
        Console.WriteLine();
    }
}