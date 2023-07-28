using Inheritance;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        private static void runApp()
        {
            SubjectTeacher subjectTeacher = new SubjectTeacher();
            Console.Write("Enter the name of subject teacher: ");
            subjectTeacher.Name = Console.ReadLine();

            Console.Write("Enter the age of subject teacher: ");
            subjectTeacher.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter the subject taught by subject teacher: ");
            subjectTeacher.SubjectTaught = Console.ReadLine();

            ClassTeacher classTeacher = new ClassTeacher();
            Console.Write("Enter the name of class teacher: ");
            classTeacher.Name = Console.ReadLine();

            Console.Write("Enter the age of class teacher: ");
            classTeacher.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter the class name of class teacher: ");
            classTeacher.ClassName = Console.ReadLine();

            CClass cClass = new CClass
            {
                ClassName = "Class A",
                Teachers = new Teacher[] { subjectTeacher, classTeacher }
            };

            Console.WriteLine("Class Name: " + cClass.ClassName);
            Console.WriteLine("Teachers: ");
            foreach (Teacher teacher in cClass.Teachers)
            {
                Console.WriteLine(" - " + teacher.Name + " (Age: " + teacher.Age + ")");
                if (teacher is SubjectTeacher subject)
                {
                    Console.WriteLine("   Subject Taught: " + subject.SubjectTaught);
                }
                else if (teacher is ClassTeacher classTeacherObj)
                {
                    Console.WriteLine("   Class Name: " + classTeacherObj.ClassName);
                }
            }
        }
    }
}
