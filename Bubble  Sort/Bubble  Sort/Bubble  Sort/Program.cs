using System;

namespace BubbleSort
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

            BubbleSort(students);

            Console.WriteLine("Sorted list of students:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void BubbleSort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {

                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
