using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Life Story");
            book.AddGrade(54);
            book.AddGrade(12);
            book.AddGrade(11);
            book.AddGrade(10);
            var getGrades = book.GetGrades();
            double result = 0;
            double highGrade = double.MinValue;
            double lowGrade = double.MinValue;
            foreach (var item in getGrades)
            {
                lowGrade = Math.Min(item, highGrade);
                highGrade = Math.Max(item, highGrade);
                result += item;
            }
            double average = result/getGrades.Count;
            // double highGrade = grades.Min();
            // double highGrade = grades.Where(x => x <= 12);
            // List<double> gradeTwelve = new List<double>();
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Average: {average:N3}");
            Console.WriteLine($"Max: {highGrade:N3}");
            Console.WriteLine($"Min: {lowGrade:N3}");
        }
    }
}
