//CLASS
//Vars are declared in the class of the program.

//NUMBERS
//in order of most range to most precision:
//ints > floats > doubles > decimals

//1. ints round down to the nearest whole

//2. floats enable decimal numbers. suffix is an f after numbers following the decimal point

//3. doubles are more precise. no suffix

//4. decimals are the most precise. suffix is an M after numbers following the decimal point

//MaxValue and MinValue are properties of all variables to show where their overflow limits are. This works with any numeric variable type.

examplevar.MaxValue - examplevar.MinValue = 0

= //"set to"
== //"is equal to"
&& //"and"
|| //"or"
% //modulo or the remainder of an equation if a decimal is present

//Math.PI and other constants exist for calculation as well

//STRINGS
//set your vars inside the class!
var name "Me"
var examplevar "and"

//variables in strings can be done as:
("String" + examplevar + " Second String");
//or, preferrably:
($"String {examplevar} Second String");
//there is a third way that involves indexing and shouldn't be bothered with

//LISTS

//a variable type that's made to store sequences of elements
//the stored elements can be any other type of variable, such as strings:
var fruits = new List<string> {"Apples", "Bananas", "Oranges", "Peaches"};

//you can continually add or remove things from lists:

fruits.Add("Dragonfruits");
fruits.Remove("Apples");

foreach (var bunch in fruits)
{
    Console.WriteLine($"Eat {bunch}!");
}

//each element in the sequence can be called upon by a zero index:
Console.WriteLine($"Eat {fruits[0]} and {fruits[1]}!");

//and you can find out how many items are in the list like so:
Console.WriteLine($"There's {fruits.Count} types of fruit in our list.");

//we can even search for specific strings or numbers in our list and find out what index it's being kept at, so we know which index to call

var search = fruits.IndexOf("Oranges");
if (search != -1)
    Console.WriteLine($"The fruit {fruits[search]} is at index {search}");
else
    Console.WriteLine($"Fruit not found.");

//fruits.IndexOf("Oranges") could be any variable
//switching fruits.IndexOf("") to something never/no longer on the list returns -1

var search = fruits.IndexOf("Apples");
if (search != -1)
    Console.WriteLine($"The fruit {fruits[search]} is at index {search}");
else
    Console.WriteLine($"Fruit not found.");

//alphabetical string sorting exists!

fruits.Sort();
Console.WriteLine($"New fruit order:");
foreach (var bunch in fruits)
{
  Console.WriteLine($"{bunch}!");
}

//numbers in lists:

var fib = new List<int> {1, 1};



//CONDITIONALS

bool a = true
print($"Control: {a}");

//Whitespace, tabs, spaces are insignificant.
//{ and } are only if you want more than one statement to be part of result of an "if" statement.

if (a)
	print("true");
else
	print("false");

//is the same as

if (a)
{
	print("true");
}
else
{
	print("false");
}

//<while> is a loop that works off of conditional statements. it won't execute once if the statement doesn't start out true. whiles require no ; after they're written if there's no "do" written earlier.

counter = 0
while (counter < 10)
counter++;
print(counter)
//1 through 10 is printed. when the counter starts at 10 or higher, nothing is returned.

//<do> is different. do executes the code first and then checks if the condition should loop.

counter = 25
do
{
counter++;
print(counter)
} while counter (<10);
//only 26 is printed. if the counter started at 0 the result would be the same.

//FOR LOOPS and FOREACH LOOPS

//for loops have 3 parts:
//the initialiser: what is the temporary variable we're looping with? in this case, it's int counter = 0;
//the condition: the for loop continues as long as this is true. in this case, it's counter < 10
//the iterator: how is the variable modified after executing the block in the for statement? in this case, it's counter++

//the end result looks like this:

for(int counter = 0; counter < 10; counter++)
{
    print(counter);
}

//there is no semicolon at the end of a for loop, just semi colons to separate its 3 parts

//here's how to find all numbers divisible by 3 with my own for loop

float remain = 0;
for (int num = 1; num < 20; num++)
{
    Console.WriteLine(num);
    remain = (num % 3);
    if (remain != 0)
    Console.WriteLine($"{num} is not divisible by 3 by moduluo {remain}.");
    else
    Console.WriteLine($"{num} is divisible by 3 with no modulo.");
}
//Console.WriteLine could just be replaced by print ot a function to add something to a text log

//NAMESPACES and USING (directives)
using System;
//this lets us write
Console.WriteLine("hey.");
//instead of having to re-define the scope of our code every time, like so:
System.Console.WriteLine("hey.");

//any time a "using" is visible, this means that we're giving ourselves a break from typing anything that's already in "using"
//Unity.Print("hey"); would be another line of code that becomes redundant when we type "using"

//You can also use custom namespaces (not as useful for unity) to introduce multiples of the same name
//We can use the same name for classes, functions and variables if they're in different namespaces

namespace N1     // N1
{
    class C1      // N1.C1
    {
        class C2   // N1.C1.C2
        {
        }
    }
    namespace N2  // N1.N2
    {
        class C2   // N1.N2.C2
        {
        }
    }
}

//now some of these things are nestled in others but each namespace can hold identically named classes/functions

//Using also lets us create alias namespaces
using Alias = System.Console;

class TestClass
{
    static void Main()
    {
        // Error
        //Alias::WriteLine("Hi");

        // OK
        Alias.WriteLine("Hi");
    }
}

//and here's how we refer to multiple namespaces in one script:

using forwinforms = System.Drawing;
using forwpf = System.Windows;
public class Converters
{
    public static forwpf::Point Convert(forwinforms::Point point) => new forwpf::Point(point.X, point.Y);
}

//global:: can also be called if it's really important that what we're doing happens globally.

