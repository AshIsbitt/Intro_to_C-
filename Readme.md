# C sharp Fundamentals

Follow along with my notes: (https://app.pluralsight.com/paths/skills/csharp)

### DotNet Core

This is a Software Development Kit, and allows a computer system to understand C# code.

DotNet Core is different to basic DotNet, as the latter is Windows only, and the former is available on all platforms. 

To build a project, you'll want to run `dotnet build` in the terminal. There are a number of terminal commands with the dotnet engine that will be greatly useful.

- `dotnet new` will allow us to create a new project. You'll need another variable at the end to specify a template.
- `dotnet run` will serach for a csproj file in the current dir, and will try to run it.
- `dotnet restore` will check any packages referenced in the csproj file and download them to the local system. These are like Python libraries, and come from NuGet, which acts as Pip

### Hello World

```csharp
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

```

This is a method called Main(), and is held within a class called Program. 

C# is inherently OOP-based.

```csharp
Main(string[] args)
```

This is a set of string arguements - you define the data type, and then give them a name. The arguements list is called "args" by convention.

Within a single strong, you can also use concatenation or interpolation.
The former uses the plus sign, and the latter uses curly braces

```csharp
// basic concatenation
Console.WriteLine("Hello " + args[0] + "!");

//string interpolation in place
Console.WriteLine($"Hello {args[0]}!");
```

**NOTE THAT EVERY COMMAND NEEDS TO END IN A SEMI-COLON**

When running `dotnet run`, you follow it up with any variables you're passing in. However, they're variables being passed to the CLI, and can sometimes cause issues. 

To solve this, insert two dashes here `dotnet run -- var`

### Syntax

If statement:

```csharp
if(condition == True){
	perform x
}
else {
	perform y
}
```

Define a variable:

```csharp
int varName;
varName = 4

string varToo = "Hello World";

var varThree = "Howdy";
```

Note that you can also define a value on the same line.
You can also just use the type "var" for the code to implicitly figure out what the variable type is. This is down to personal preference when writing code.

```csharp
// Create an array of 3 items of type Double
double[] numbers = new double[3];
numbers[0] = 14.1
```

This creates an array in a specific data type. Note that this is the same as the "string[] args" that is in every method call. You can write into certain elements as seen as well. 

You can also straight up create a new array like so:

```csharp
var numbers = new double[3] {12.7, 10.3, 6.1}
```

This allows for you to shorter and more readable code.

Iterating throguh an array:

```csharp
foreach(double number in numbers) {
	do something
}
```

The data needs to be correct in the brackets, although you can make use of the "Var" keyword instead of "double"

**Lists**

```csharp
using System.Collections.Generic;

List<double> grades  = new List<double>();
        	grades.Add(43.2);

```

### Classes and Objects

Creating a new class is as simple as writing

```csharp
namespace GradeBook{
    
    class Book {

    }
}
```

and calling the class just uses the class's name. Generally, you create a new file for each class.

The new file will also need a namespace, which is also often the name of the directory.

**Defining methods**

```csharp
public void AddGrade(double grade) {

}
```

- public/private - this is the level of access that the method has 
- static - this means that the class is related to the class, not to the object. You need to call the class, not the object, to run this method.
- void - this means that the method doesn't return a value. Omit this is you're writing a method that would use the python "return" command
AddGrade - this is the name of the method
- double grade - this is the single arguement the method is expecting to be passed, a double, which it is storing in the name "grade"

Class attributes get written within the curly braces of the class, but outside of the methods. 

```csharp
class Book {
    //Attributes go out here
    List<double> grades;

    public void AddGrade(double grade) 
    {

    }
}
```

**Initialising attributes**

We need a constructor method to initialise our attributes within the class. Otherwise, nothing will run correctly.

To do this, we have a new public method with the same name as the class, and within this, we create the variable.

```csharp
public Book()
    {
        grades = new List<double>();
    }
```

### Unit Testing

Keep your unit testing code in a separate folder so it doesn't mess with the source code.

```
- Project
    - src
        - GradeBook
    - test
        - GradeBook.Tests
```

within the "test" directory, run `dotnet new xunit` to set up a directory ready for the test code.

Unit tests appear as standard C# code, but has [Fact] over each method. 

Unit tests are often broken up into three parts

- arrange - where the test data is organised and values are set
- act - where any computation/calculations are done to come up with a specific result
- assert - where the result of the act is compared with the data in the arrange.

You will need to add a reference to the tests folder to let it access the classes in the src folder. This can be done with dotnet, or within the csharp code. 
`dotnet add reference <path>` - when doing it this way, the <path> is written within the Gradebook.Tests folder, and references the csproj file in the src folder.

You may also need to return to the Book class and make it a public class. Otherwise, it won't be accessible from the tests folder. 

### Reference and Value types

Reference types are a type of variable that points to another place in memory that stores the data from the variable. 

IE, you may have a variable "b", which only stores the number 1072, and item 1072 in RAM is where the data is stored that the code things is in the variable.

Value types commonly only include a number (int, double, float etc) - and are instead stored straight in the location the variable points to. 

Solution files are used in DOTNET to run everything at once - the tests, and the main program. It' keeps track of everything.

`dotnet new sln` to create the solution file

`dotnet sln <.sln file> add <dir>` - this directs to the .csproj files you want to run.

**Struct**

A Struct is written directly within the namespace, outside of a class, and is considered a separate data type that can be more efficient that reference data types.

### Controlling the Flow of Execution

**IF statements**

```csharp
if (conditional)
{
    do something
}
else if (new conditional)
{
    do something else
}
else 
{
    do even more
}
```

**Boolean Operators**

&& AND
|| OR
== EQUAL TO

**Loops**

There are three different versions of loops, and each one is more useful in different situations.

```csharp
foreach(var x in y)
{
    do something
}

do
{
    something
    condition++
} while (conditional);

//start, stop, do after each loop
for(var i = 0; i < value; i++;)
{

}
```

**Jumping Statements**

These allow for you to jump over a line of code to get to another.

The most used one of these is a `break` command, often used within an IF statement in a FOR loop, allowing you to break out of the loop if a condition is met early.

`Continue` instead will exit out of that specific loop and will run back to the top of the FOR statement.

`GOTO` is also possible, but very uncommon to actually use. The tag added to GOTO ends in a colon, not a semicolon.

```csharp
foreach {
    if(x == 2)
    {
        goto finish;
    }
}

finish:
```

**Switch case**

These allow you to use a single statement to perform a task based on the content of a variable. This can be used differently to an IF statement.

```csharp
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
```
In the above example,the contents of the char variable "letter" is being tested.

```csharp
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
```

This is a more advanced use of the Switchcase, that allows you to store the variable you're giving it in the var D and test it against a condition.

```csharp
var input = Console.ReadLine()
```

This line of code above acts like a python `input` command.

### Error Handling

```csharp
throw new ArgumentException($"Invalid grade");
```

This line is a basic exception error in C#. Note that this is creating the error, not handling it. 

```csharp
try
{
    do something
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    do this if try or catch triggers
}
```

This example of a TRY/CATCH code block will just output the exception message when you run into any error.

You can also set "exception" to a specific error type.

### Building Types

Method overloading is the process of allowing for multiple methods with the same name.

This works because the compiler is looking at the "method signature" - including the identifier, the arguements, and the arguement types. (IE, the "char letter" in AddLetterGrade)

Methods can also have properties, which are similar to fields that can store data. However, they use different syntax.

Properties of a class are basically just Getters and Setters:

```csharp
public string Name 
{
    get
    {
        return name;
    }
    set
    {
        if(String.IsNullorEmpty(value))
        {
            name = value;   
        }
    }
}
```

