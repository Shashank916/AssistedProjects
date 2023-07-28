using System;

namespace SelectionSort
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

            SelectionSort(students);

            Console.WriteLine("Sorted list of students:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void SelectionSort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(arr[j], arr[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    string temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
    }
}
