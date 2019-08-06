using System;
using System.Collections.Generic;
using System.IO;

namespace library
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }
        protected List<float> grades;

        public event NameChangedDelegate NameChanged;
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            { 
                //throw an exception if the name of a gradebook is set to null or empty!
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty!");
                }

                if (_name != value && NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                _name = value; 
            }
        }

        //This method lists the list of grades added
        public void WriteGrades(StreamWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }

        public void AddGrade(float grade) => grades.Add(grade);

        public virtual GradeStatistics ComputeStatistics()
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
