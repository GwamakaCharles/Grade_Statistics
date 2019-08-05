using System;
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

        [Fact]
        public void GradeBookVariablesHoldAReference()
        {
        //Given
            GradeBook g1 = new GradeBook();
        //When
            GradeBook g2 = g1;
            // g1 = new GradeBook();
        //Then
            g1.Name = "Warren is a beautiful Name!";
            Assert.Equal(g2.Name, g1.Name);
        }

        [Fact]
        public void UsingArrays()
        {
        //Given
            float[] grades;
            grades = new float[3];
        //When
            AddGrades(grades);
        //Then
            Assert.Equal(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades) => grades[1] = 89.1f;
    }
}
