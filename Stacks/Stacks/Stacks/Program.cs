using System;

namespace Stacks
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

    public class Stack<T>
    {
        private Node<T> top;

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = top;
            top = newNode;
        }

        public T Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T data = top.Data;
            top = top.Next;
            return data;
        }

        public void Display()
        {
            Node<T> current = top;
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
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("Enter the number of elements to push onto the stack: ");
            int numElements = int.Parse(Console.ReadLine());

            for (int i = 0; i < numElements; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                int element = int.Parse(Console.ReadLine());
                myStack.Push(element);
            }

            Console.WriteLine("Elements in the stack:");
            myStack.Display();

            Console.WriteLine("Popping elements from the stack:");
            while (true)
            {
                try
                {
                    int poppedElement = myStack.Pop();
                    Console.WriteLine("Popped: " + poppedElement);
                }
                catch (InvalidOperationException)
                {
                    break;
                }
            }
        }
    }
}
