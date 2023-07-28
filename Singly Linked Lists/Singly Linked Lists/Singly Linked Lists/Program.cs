using System;

namespace SinglyLinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SingleLinkedList<T>
    {
        private Node<T> head;

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
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
            SingleLinkedList<int> myList = new SingleLinkedList<int>();

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
