using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        private static void runApp()
        {
            Console.WriteLine("Enter the number of elements in the sorted array: ");
            int numElements = int.Parse(Console.ReadLine());

            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the value to search for: ");
            int searchValue = int.Parse(Console.ReadLine());

            int foundIndex = BinarySearch(array, searchValue);

            if (foundIndex != -1)
            {
                Console.WriteLine("Value " + searchValue + " found at index " + foundIndex);
            }
            else
            {
                Console.WriteLine("Value " + searchValue + " not found in the array.");
            }
        }

        private static int BinarySearch(int[] array, int searchValue)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == searchValue)
                {
                    return mid;
                }
                else if (array[mid] < searchValue)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; 
        }
    }
}
