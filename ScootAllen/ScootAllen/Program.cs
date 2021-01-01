using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScootAllen
{
    class Program
    {
        static void Main(string[] args)
        { 
            Book book = new Book("Abirs Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            double result = 0;
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            foreach (var number in grades)
            {
                if(number > highGrade)
                {
                    highGrade = Math.Max(number, highGrade);
                    lowGrade = Math.Min(number, lowGrade);
                    result += number;
                }
            }

            result = result / grades.Count;
            Console.WriteLine($"Lowest Grade is {lowGrade}");
            Console.WriteLine($"Highest Grade is {highGrade}");
            Console.WriteLine($"Average : {result}");

        }
    }
}
