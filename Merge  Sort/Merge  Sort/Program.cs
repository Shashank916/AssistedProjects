using System;

namespace MergeSort
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

            MergeSort(marks, 0, marks.Length - 1);

            Console.WriteLine("Sorted marks of subjects in ascending order:");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
        }

        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                leftArr[i] = arr[left + i];
            }

            for (int j = 0; j < n2; j++)
            {
                rightArr[j] = arr[mid + 1 + j];
            }

            int x = 0, y = 0;
            int k = left;

            while (x < n1 && y < n2)
            {
                if (leftArr[x] <= rightArr[y])
                {
                    arr[k] = leftArr[x];
                    x++;
                }
                else
                {
                    arr[k] = rightArr[y];
                    y++;
                }
                k++;
            }

            while (x < n1)
            {
                arr[k] = leftArr[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                arr[k] = rightArr[y];
                y++;
                k++;
            }
        }
    }
}
