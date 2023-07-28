using System;

namespace InsertionSort
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

            InsertionSort(students);

            Console.WriteLine("Sorted list of students:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void InsertionSort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                string key = arr[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(arr[j], key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }
    }
}
