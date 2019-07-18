using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book();
            book.AddGrade(54);

            List<double> grades = new List<double>(){12,15.6 };
            grades.Add(12);
           
           
            // print list 
            double result = 0;
            foreach (var item in grades)
            {
                result += item;
            }
            double average = result/grades.Count;
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Average: {average:N3}");
        }
    }
}
