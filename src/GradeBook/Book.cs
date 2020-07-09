using System;
using System.Collections.Generic;

namespace GradeBook
{
	
	class Book 
	{
		//explicit constructor to init the "grades" var
		//convention is that it has no return type (no void)
		//and has the same name as the class
		public Book(string name)
		{
			grades = new List<double>();
			//"this" refers to the object attribute called "name"
			this.name = name;
		}
		
		//Attributes go out here
		List<double> grades ;
		private string name;

		//methods
		public void AddGrade(double grade) 
		{
			grades.Add(grade);
		}

		public void showStats() 
		{
			var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

        	foreach(var number in grades) 
        	{
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
        	}

        	//Get the average by dividing by the number of items in the List 
        	result /= grades.Count;

        	//result:N1 is a formatted version of result, with only 1 DP
        	Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The lowest grade is {lowGrade:N1}");
		}
	}
}

