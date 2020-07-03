using System;

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

			double[] numbers = new double[3];
        	numbers[0] = 12.7;

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
