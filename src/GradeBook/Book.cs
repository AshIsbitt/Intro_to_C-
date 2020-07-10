using System;
using System.Collections.Generic;

namespace GradeBook
{
	
	public class Book 
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

		public Statistics getStats() 
		{
			var result = new Statistics();
			result.Average = 0.0;
			result.High = double.MinValue;
			result.Low = double.MaxValue;

        	foreach(var grade in grades) 
        	{
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
        	}

        	//Get the average by dividing by the number of items in the List 
        	result.Average /= grades.Count;

        	return result;
		}
	}
}

