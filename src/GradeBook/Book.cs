using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        // field
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        List<double> grades;

        public List<double> GetGrades()
        {
            return grades;
        }
    }
}