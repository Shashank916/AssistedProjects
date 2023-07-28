using System;
using System.Text;

namespace TextHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        private static void doApp()
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Uppercase: " + userInput.ToUpper());
            Console.WriteLine("Lowercase: " + userInput.ToLower());
            Console.WriteLine("Length: " + userInput.Length);
            int wordCount = CountWords(userInput);
            Console.WriteLine("Number of words: " + wordCount);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < wordCount; i++)
            {
                stringBuilder.Append("Word" + (i + 1) + " ");
            }
            string result = stringBuilder.ToString();
            Console.WriteLine("Concatenated string: " + result);
        }

        private static int CountWords(string input)
        {
            string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
