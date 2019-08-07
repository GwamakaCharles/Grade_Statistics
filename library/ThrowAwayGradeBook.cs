using System;

namespace library
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);

            Console.WriteLine($"Removed the lowest grade: {lowest}");
            
            return base.ComputeStatistics();
        }
    }
}