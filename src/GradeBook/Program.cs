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
            book.ShowStatistics();
            var getGrades = book.GetGrades();
           
        }
    }
}
