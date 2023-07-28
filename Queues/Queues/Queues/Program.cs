using System;

namespace QueueDemo
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

    public class Queue<T>
    {
        private Node<T> front;
        private Node<T> rear;

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public T Dequeue()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T data = front.Data;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            return data;
        }

        public void Display()
        {
            Node<T> current = front;
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
            Queue<int> myQueue = new Queue<int>();

            Console.WriteLine("Enter the number of elements to enqueue: ");
            int numElements = int.Parse(Console.ReadLine());

            for (int i = 0; i < numElements; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                int element = int.Parse(Console.ReadLine());
                myQueue.Enqueue(element);
            }

            Console.WriteLine("Elements in the queue:");
            myQueue.Display();

            Console.WriteLine("Dequeueing elements from the queue:");
            while (true)
            {
                try
                {
                    int dequeuedElement = myQueue.Dequeue();
                    Console.WriteLine("Dequeued: " + dequeuedElement);
                }
                catch (InvalidOperationException)
                {
                    break;
                }
            }
        }
    }
}
