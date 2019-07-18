using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new []{12,15.6};
            List<int> grades = new List<int>();
            grades.Add(12);
            grades.Add(11);
            grades.Add(10);
            double result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }

            // print list 
            foreach (var item in grades.FindAll(x => x > 11))
            {
                Console.WriteLine(item);
            }
            System.Console.WriteLine("\n\n");
            Console.WriteLine(result);
        }
    }
}
