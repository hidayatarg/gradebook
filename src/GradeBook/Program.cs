using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new []{12,15.6, 12};
            List<double> grades = new List<double>(){12,15.6 };
            grades.Add(12);
           
            double result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }

            // print list 
            double result2 = 0;
            foreach (var item in grades)
            {
                result2 += item;
            }
            double average = result2/grades.Count;
            System.Console.WriteLine("\n\n");
            Console.WriteLine(result);
            System.Console.WriteLine("\n\n");
            Console.WriteLine($"Result: {result2}");
            Console.WriteLine($"Average: {average:N3}");
        }
    }
}
