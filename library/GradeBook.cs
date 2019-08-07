using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace library
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }
        protected List<float> grades;

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();   
        }

        // //This method lists in a txt file the list of grades added
        // public override void WriteGrades(TextWriter destination)
        // {
        //     for (int i = 0; i < grades.Count; i++)
        //     {
        //         Console.WriteLine(grades[i]);
        //     }
        // }

        public override void AddGrade(float grade) => grades.Add(grade);

        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}
