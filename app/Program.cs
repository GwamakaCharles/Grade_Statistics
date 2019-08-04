using library;
using System;


namespace app
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
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);
        }
    }
}

