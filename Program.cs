using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Your average is a "+stats.AverageGrade);
            Console.WriteLine("Your highest grade is a "+stats.HighestGrade);
            Console.WriteLine("Your lowest grade is a "+stats.LowestGrade);
        }
    }
}
