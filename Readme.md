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

