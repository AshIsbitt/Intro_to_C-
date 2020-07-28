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
			Name = name;
		}

		public void AddLetterGrade(char letter)
		{
			switch(letter)
			{
				case 'A':
					AddGrade(90);
					break;
				case 'B':
					AddGrade(80);
					break;
				case 'C':
					AddGrade(70);
					break;
				case 'D':
					AddGrade(60);
					break;
				default:
					AddGrade(0);
					break;

			}
		}

		//methods
		public void AddGrade(double grade) 
		{
			
			if(grade <= 100 && grade >= 0)
			{
				grades.Add(grade);
			}
			else
			{
				//Console.WriteLine("Invalid Value");

				throw new ArgumentException($"Invalid grade");
			}

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

        	switch(result.Average)
        	{
        		case var d when d >= 90.0:
        			result.Letter = 'A';
        			break;
        		case var d when d >= 80.0:
        			result.Letter = 'B';
        			break;
        		case var d when d >= 70.0:
        			result.Letter = 'C';
        			break;
        		case var d when d >= 60.0:
        			result.Letter = 'D';
        			break;
    			default:
    				result.Letter = 'F';
    				break;

        	}

        	return result;
		}

		//Attributes go out here
		private List<double> grades;
		private string name;

		public string Name 
		{
			get; 
			set;
		}
		
		readonly string category = "Science";
	}
}

