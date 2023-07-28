using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        private static void doApp()
        {
            Console.WriteLine("1. Create a new text file");
            Console.WriteLine("2. Read an existing text file");
            Console.Write("Enter your choice (1 or 2): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateFile();
                    break;
                case "2":
                    ReadFile();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void CreateFile()
        {
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();

            try
            {
                Console.WriteLine("Enter text (press Enter on a new line to save and exit):");
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    string line;
                    do
                    {
                        line = Console.ReadLine();
                        writer.WriteLine(line);
                    } while (!string.IsNullOrWhiteSpace(line));
                }

                Console.WriteLine("Text file created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private static void ReadFile()
        {
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
