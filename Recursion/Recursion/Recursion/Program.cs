using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        private static void runApp()
        {
            Console.WriteLine("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());

            string[] students = new string[numStudents];
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write("Enter the name of student " + (i + 1) + ": ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("Printing names of students using recursion:");
            PrintViaRecursion(students, 0);
        }

        private static void PrintViaRecursion(string[] arr, int index)
        {
            if (index == arr.Length)
            {
                return;
            }

            Console.WriteLine(arr[index]);
            PrintViaRecursion(arr, index + 1);
        }
    }
}
