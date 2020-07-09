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

            book.showStats();
        }	
    }
}
