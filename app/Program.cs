using library;
using System;


namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            //Adding grades to the grades list.
            book.AddGrade(91);            
            book.AddGrade(89.5f);
            book.AddGrade(75);
            
            //Prints to the console the list of grades added
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            WriteLine("Highest Grade",stats.HighestGrade);
            WriteLine("Lowest Grade", stats.LowestGrade);
            WriteLine("The Average Grade", stats.AverageGrade);
            WriteLine(stats.Description, stats.LetterGrade);
        }

        private static void WriteLine(string description, float result) => Console.WriteLine($"{description}: {result}");
        private static void WriteLine(string description, string result) => Console.WriteLine($"{description}: {result:F2}");

    }
}

