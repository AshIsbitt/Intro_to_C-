using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

        	//define a var
        	//float x = 34.1;
        	//float y = 4.1;
        	//var result = x + y;

			//double[] numbers = new double[3];
        	//numbers[0] = 12.7;

        	//Arrays and Lists
        	var numbers = new[] {12.7, 10.3, 6.1, 4.2, 7.6};
        	List<double> grades  = new List<double>();
        	grades.Add(43.2);

        	var result = 0.0;

        	foreach(var number in grades) {
        		result += number;
        	}

        	//Get the average by dividing by the number of items in the List 
        	result /= grades.Count;
        	//result:N1 is a formatted version of result, with only 1 DP
        	Console.WriteLine($"The average grade is {result:N1}");



        	//IF statement
        	if(args.Length > 0) {

	        	// basic concatenation
	            Console.WriteLine("Hello " + args[0] + "!");

	            //string interpolation in place
	            Console.WriteLine($"Hello {args[0]}!");
	        }
	        else {
	        	Console.WriteLine("Hello!");
	        }


        }	
    }
}
