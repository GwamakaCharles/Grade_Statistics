using library;
using System;
using System.IO;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradebook();

            GetBookName(book);

            AddGrades(book);

            // SaveGrades(book);

            WriteResults(book);
        }

        private static IGradeTracker CreateGradebook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void WriteResults(IGradeTracker book)
        {
            //Display the grades in a console
            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            //Display the statistics
            GradeStatistics stats = book.ComputeStatistics();
            WriteLine("Highest Grade", stats.HighestGrade);
            WriteLine("Lowest Grade", stats.LowestGrade);
            WriteLine("The Average Grade", stats.AverageGrade);
            WriteLine(stats.Description, stats.LetterGrade);
        }

        // //Save grades in a txt file
        // private static void SaveGrades(IGradeTracker book)
        // {
        //     using (StreamWriter outputFile = File.CreateText("grades.txt"))
        //     {
        //         book.WriteGrades(outputFile);
        //     }
        // }

        private static void AddGrades(IGradeTracker book)
        {
            //Adding grades to the grades list.
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(IGradeTracker book)
        {
            //handle the exception if the name of a grade book is set to null or empty.
            try
            {
                Console.WriteLine("Please enter a Grade Book Name:");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void WriteLine(string description, float result) => Console.WriteLine($"{description}: {result}");
        private static void WriteLine(string description, string result) => Console.WriteLine($"{description}: {result:F2}");

    }
}

