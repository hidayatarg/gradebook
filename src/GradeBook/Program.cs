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
            var getGrades = book.GetGrades();
            foreach (var item in getGrades)
            {
                System.Console.WriteLine($"Incoming Grade {item}");
            }


            var grades = new List<double>(){12,15.6 };
            grades.Add(12);
           
           
            // print list 
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
            var gradeTwelve = grades.Where(x => x > 12);
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Average: {average:N3}");
            Console.WriteLine($"Max: {highGrade:N3}");
            Console.WriteLine($"Min: {lowGrade:N3}");
        }
    }
}
