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
            Console.WriteLine("Insert Grades");
            Console.WriteLine("Insert first grade:");
            float grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insert Second grade:");
            float grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insert Third grade:");
            float grade3 = float.Parse(Console.ReadLine());

            book.AddGrade(grade1);
            book.AddGrade(grade2);
            book.AddGrade(grade3);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade is :");
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine("HighestGrade is :");
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine("LowestGrade is :");
            Console.WriteLine(stats.LowestGrade);

            
        }
    }


    
} 
