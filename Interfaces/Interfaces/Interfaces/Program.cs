using System;

namespace Interfaces
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
            Console.WriteLine("Enter Subject Teacher's name: ");
            subjectTeacher.Name = Console.ReadLine();

            Console.WriteLine("Enter Subject Teacher's age: ");
            int.TryParse(Console.ReadLine(), out int subjectTeacherAge);
            subjectTeacher.Age = subjectTeacherAge;

            Console.WriteLine("Enter Subject Taught: ");
            subjectTeacher.SubjectTaught = Console.ReadLine();

            ClassTeacher classTeacher = new ClassTeacher();
            Console.WriteLine("\nEnter Class Teacher's name: ");
            classTeacher.Name = Console.ReadLine();

            Console.WriteLine("Enter Class Teacher's age: ");
            int.TryParse(Console.ReadLine(), out int classTeacherAge);
            classTeacher.Age = classTeacherAge;

            Console.WriteLine("Enter Class Name: ");
            string className = Console.ReadLine();

            CClass cClass = new CClass
            {
                ClassName = className,
                Teachers = new Teacher[] { subjectTeacher, classTeacher }
            };

            Console.WriteLine("\nClass Name: " + cClass.ClassName);
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
