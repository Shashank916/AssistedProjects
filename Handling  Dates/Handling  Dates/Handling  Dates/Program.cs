using System;

namespace DateHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        private static void doApp()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDate);
            Console.Write("Enter a specific date (format: MM/dd/yyyy): ");
            string inputDate = Console.ReadLine();
            if (DateTime.TryParse(inputDate, out DateTime specificDate))
            {
                Console.WriteLine("Specific date: " + specificDate);
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            Console.WriteLine("Formatted date: " + formattedDate);
            Console.Write("Enter the number of days to add to the current date: ");
            string inputDays = Console.ReadLine();
            if (int.TryParse(inputDays, out int daysToAdd))
            {
                DateTime futureDate = currentDate.AddDays(daysToAdd);
                Console.WriteLine("Date " + daysToAdd + " days from now: " + futureDate);
            }
            else
            {
                Console.WriteLine("Invalid input for days.");
            }
            Console.Write("Enter another date (format: MM/dd/yyyy): ");
            string futureInputDate = Console.ReadLine();
            if (DateTime.TryParse(futureInputDate, out DateTime userFutureDate))
            {
                TimeSpan difference = userFutureDate - currentDate;
                Console.WriteLine("Difference between dates in days: " + difference.TotalDays);
            }
            else
            {
                Console.WriteLine("Invalid date format for the second date.");
            }
        }
    }
}
