using Class;
using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        private static void runApp()
        {
            Subject[] subjects = new Subject[2];
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.Write("Enter the name of subject " + (i + 1) + ": ");
                string subjectName = Console.ReadLine();

                Console.Write("Enter the code of subject " + (i + 1) + ": ");
                int subjectCode = int.Parse(Console.ReadLine());

                subjects[i] = new Subject { Name = subjectName, Code = subjectCode };
            }

            Teacher[] teachers = new Teacher[2];
            for (int i = 0; i < teachers.Length; i++)
            {
                Console.Write("Enter the name of teacher " + (i + 1) + ": ");
                string teacherName = Console.ReadLine();

                Console.Write("Enter the age of teacher " + (i + 1) + ": ");
                int teacherAge = int.Parse(Console.ReadLine());

                Console.Write("Enter the department of teacher " + (i + 1) + ": ");
                string teacherDepartment = Console.ReadLine();

                teachers[i] = new Teacher { Name = teacherName, Age = teacherAge, Department = teacherDepartment };
            }

            Student[] students = new Student[2];
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Enter the name of student " + (i + 1) + ": ");
                string studentName = Console.ReadLine();

                Console.Write("Enter the age of student " + (i + 1) + ": ");
                int studentAge = int.Parse(Console.ReadLine());

                Console.Write("Enter the grade of student " + (i + 1) + ": ");
                string studentGrade = Console.ReadLine();

                students[i] = new Student { Name = studentName, Age = studentAge, Grade = studentGrade };
            }

            CClass cClass = new CClass
            {
                ClassName = "Class A",
                Subjects = subjects,
                Teachers = teachers,
                Students = students
            };

            Console.WriteLine("Class Name: " + cClass.ClassName);
            Console.WriteLine("Subjects: ");
            foreach (Subject subject in cClass.Subjects)
            {
                Console.WriteLine(" - " + subject.Name + " (Code: " + subject.Code + ")");
            }

            Console.WriteLine("Teachers: ");
            foreach (Teacher teacher in cClass.Teachers)
            {
                Console.WriteLine(" - " + teacher.Name + " (Age: " + teacher.Age + ", Department: " + teacher.Department + ")");
            }

            Console.WriteLine("Students: ");
            foreach (Student student in cClass.Students)
            {
                Console.WriteLine(" - " + student.Name + " (Age: " + student.Age + ", Grade: " + student.Grade + ")");
            }
        }
    }
}
