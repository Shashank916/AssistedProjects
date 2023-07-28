using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class HighSchoolGradeCard : BasicGradeCard
    {
        public override void DisplayGradeCard()
        {
            Console.WriteLine("This is the high school grade card.");
        }
    }
}
