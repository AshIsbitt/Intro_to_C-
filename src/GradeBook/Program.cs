using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program 
    {
        static void Main(string[] args)
        {
            var book = new Book("My Grades");
            book.AddGrade(89.1);
            book.AddGrade(40.6);
            book.AddGrade(91.3);

            var stats = book.getStats();

            //result:N1 is a formatted version of result, with only 1 DP
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}")
        }	
    }
}
