using System;
using System.IO;

namespace library
{
    public abstract class GradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
        public event NameChangedDelegate NameChanged;
        protected string _name;
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
    }
}