using library;
using Xunit;

namespace test_library
{
    public class GradeBookTests
    {
        [Fact]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.Equal(90, result.HighestGrade);
        }

        [Fact]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.Equal(10, result.LowestGrade);
        }

        [Fact]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.Equal(85.16, result.AverageGrade, 1);
        }


    }
}
