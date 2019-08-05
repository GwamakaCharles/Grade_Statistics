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
            WriteLine("Highest Grade",stats.HighestGrade);
            WriteLine("Lowest Grade", stats.LowestGrade);
            WriteLine("The Average Grade", stats.AverageGrade);
        }

        private static void WriteLine(string description, float grade) => System.Console.WriteLine($"{description}: {grade:F2}");
    }
}

