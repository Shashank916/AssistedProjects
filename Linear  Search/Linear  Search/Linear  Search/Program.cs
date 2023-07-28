using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        private static void runApp()
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int numElements = int.Parse(Console.ReadLine());

            int[] array = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the value to search for: ");
            int searchValue = int.Parse(Console.ReadLine());

            int foundIndex = LinearSearch(array, searchValue);

            if (foundIndex != -1)
            {
                Console.WriteLine("Value " + searchValue + " found at index " + foundIndex);
            }
            else
            {
                Console.WriteLine("Value " + searchValue + " not found in the array.");
            }
        }

        private static int LinearSearch(int[] array, int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    return i;
                }
            }

            return -1; 
        }
    }
}

