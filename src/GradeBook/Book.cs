using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        // field
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
         public void ShowStatistics()
        {
            double result = 0;
            double highGrade = double.MinValue;
            double lowGrade = double.MinValue;
            foreach (var item in grades)
            {
                lowGrade = Math.Min(item, highGrade);
                highGrade = Math.Max(item, highGrade);
                result += item;
            }
            double average = result/grades.Count;
            // double highGrade = grades.Min();
            // double highGrade = grades.Where(x => x <= 12);
            // List<double> gradeTwelve = new List<double>();
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Average: {average:N3}");
            Console.WriteLine($"Max: {highGrade:N3}");
            Console.WriteLine($"Min: {lowGrade:N3}");
        }
         public List<double> GetGrades()
        {
            return grades;
        }
        private List<double> grades;
        private string name;
       
    }
}