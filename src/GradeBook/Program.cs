using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[]{12,15.6};
            double result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            Console.WriteLine(result);
        }
    }
}
