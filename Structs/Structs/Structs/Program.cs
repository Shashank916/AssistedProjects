using System;

namespace Struct
{
    struct Student
    {
        public string Name;
        public int Age;
        public string Course;
        public double SGPA;
    }

    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        private static void doApp()
        {
            Student student;
            Console.Write("Enter student's name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter student's age: ");
            student.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter student's course: ");
            student.Course = Console.ReadLine();

            Console.Write("Enter student's SGPA: ");
            student.SGPA = double.Parse(Console.ReadLine());

            Console.WriteLine("Student details:");
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
            Console.WriteLine("Course: " + student.Course);
            Console.WriteLine("SGPA: " + student.SGPA);
        }
    }
}
