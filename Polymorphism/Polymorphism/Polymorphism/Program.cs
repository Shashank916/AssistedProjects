using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        private static void runApp()
        {
            BasicGradeCard basicGradeCard = new BasicGradeCard();
            BasicGradeCard elementarySchoolGradeCard = new ElementarySchoolGradeCard();
            BasicGradeCard middleSchoolGradeCard = new MiddleSchoolGradeCard();
            BasicGradeCard highSchoolGradeCard = new HighSchoolGradeCard();

            Console.WriteLine("Basic Grade Card:");
            basicGradeCard.DisplayGradeCard();

            Console.WriteLine("\nElementary School Grade Card:");
            elementarySchoolGradeCard.DisplayGradeCard();

            Console.WriteLine("\nMiddle School Grade Card:");
            middleSchoolGradeCard.DisplayGradeCard();

            Console.WriteLine("\nHigh School Grade Card:");
            highSchoolGradeCard.DisplayGradeCard();
        }
    }
}
