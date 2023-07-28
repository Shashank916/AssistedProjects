using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        private static void runApp()
        {
            Console.Write("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());
            string[] studentNames = new string[numStudents];
            int[] studentMarks = new int[numStudents];
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write("Enter the name of student " + (i + 1) + ": ");
                studentNames[i] = Console.ReadLine();

                Console.Write("Enter the marks of student " + (i + 1) + ": ");
                studentMarks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nStudent Details:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Name: " + studentNames[i] + ", Marks: " + studentMarks[i]);
            }
        }
    }
}
