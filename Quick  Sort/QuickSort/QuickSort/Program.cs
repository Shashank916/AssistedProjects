using System;

namespace QuickSort
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

            QuickSort(marks, 0, marks.Length - 1);

            Console.WriteLine("Sorted marks of subjects in ascending order:");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
        }

        private static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);
                QuickSort(arr, low, partitionIndex - 1);
                QuickSort(arr, partitionIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
