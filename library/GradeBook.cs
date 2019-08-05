using System;
using System.Collections.Generic;


namespace library
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }
        List<float> grades;

        public event NameChangedDelegate NameChanged;
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            { 
                if(!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                    _name = value; 
                }  
            }
        }
        
        public void AddGrade(float grade) => grades.Add(grade);

        public GradeStatistics ComputeStatistics()
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
