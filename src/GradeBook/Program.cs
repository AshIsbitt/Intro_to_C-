using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
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
