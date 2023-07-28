using System;

namespace DoublyLinkedListDemo
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    public class DoubleLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
        }

        public void Display()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        private static void runApp()
        {
            DoubleLinkedList<int> myList = new DoubleLinkedList<int>();

            Console.WriteLine("Enter the number of elements to add: ");
            int numElements = int.Parse(Console.ReadLine());

            for (int i = 0; i < numElements; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                int element = int.Parse(Console.ReadLine());
                myList.Add(element);
            }

            Console.WriteLine("The elements in the linked list are:");
            myList.Display();
        }
    }
}
