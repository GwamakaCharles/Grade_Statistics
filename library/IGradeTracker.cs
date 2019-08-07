using System.Collections;
using System.IO;

namespace library
{
    public interface IGradeTracker : IEnumerable
    {
        string Name { get; set; }

        void AddGrade(float grade);

        GradeStatistics ComputeStatistics();

        // void WriteGrades(TextWriter destination);
    }
}