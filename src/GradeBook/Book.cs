using System;
using System.Collections.Generic;

namespace GradeBook
{

	public delegate void GradeAddedDelegate(object sender, EventArgs args);
	
	public class NamedObject
	{
		public NamedObject(string name)
		{
			Name = name;
		}

		public string Name
		{
			get;
			set;
		}
	}

	public interface IBook
	{
		void AddGrade(Double grade);
		statistics getStats();
		string Name{ get; }
		event GradeAddedDelegate GradeAdded;
	}

	public abstract class Book : NamedObject, IBook
	{
		public Book(string name) : base(name)
		{

		}

		public abstract void AddGrade(double grade);

		public event GradeAddedDelegate GradeAdded;

		public statistics getStats()
		{
			throw new NotImplementedException();
		}

	}

	public class InMemoryBook : Book, IBook
	{
		//explicit constructor to init the "grades" var
		//convention is that it has no return type (no void)
		//and has the same name as the class
		public InMemoryBook(string name) : base(name)
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
		public override void AddGrade(double grade) 
		{
			
			if(grade <= 100 && grade >= 0)
			{
				grades.Add(grade);
				if(GradeAdded != null)
				{
					GradeAdded(this, new EventArgs());
				}
			}
			else
			{
				//Console.WriteLine("Invalid Value");

				throw new ArgumentException($"Invalid grade");
			}

		}

		public override event GradeAddedDelegate GradeAdded;

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
		
		readonly string category = "Science";
	}
}

