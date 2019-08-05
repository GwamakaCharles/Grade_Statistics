using library;
using System;


namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            //Envoking an event i.e NameChanged, to display the name change.
            GradeBook book = new GradeBook();
            book.NameChanged += OnNameChanged;
            book.Name = "Warren's Grade Book!";
            book.Name = "Grade Book!";

            //Adding grades to the grades list.
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            WriteLine("Highest Grade",stats.HighestGrade);
            WriteLine("Lowest Grade", stats.LowestGrade);
            WriteLine("The Average Grade", stats.AverageGrade);
        }

        private static void WriteLine(string description, float result) => System.Console.WriteLine($"{description}: {result:F2}");

        static void OnNameChanged(object sender, NameChangedEventArgs args) => Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
    }
}

