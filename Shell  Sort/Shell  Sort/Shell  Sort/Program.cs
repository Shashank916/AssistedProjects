using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        private static void runApp()
        {
            Console.WriteLine("Enter the number of subjects: ");
            int numSubjects = int.Parse(Console.ReadLine());

            int[] marks = new int[numSubjects];
            for (int i = 0; i < numSubjects; i++)
            {
                Console.Write("Enter the marks of subject " + (i + 1) + ": ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            ShellSort(marks);

            Console.WriteLine("Sorted marks of subjects in ascending order:");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
        }

        private static void ShellSort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }
                    arr[j] = temp;
                }
            }
        }
    }
}
