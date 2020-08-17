//CLASS
Vars are declared in the class of the program.

//NUMBERS
range > precision:
ints > floats > doubles > decimals

1. ints round down to the nearest whole

2. floats enable decimal numbers. suffix is an f after numbers following the decimal point

3. doubles are more precise. no suffix

4. decimals are the most precise. suffix is an M after numbers following the decimal point

MaxValue and MinValue are properties of all variables to show where their overflow limits are. This works with any numeric variable type.

examplevar.MaxValue - examplevar.MinValue = 0

Math.PI and other constants exist

//STRINGS

set as vars in the class
var name "Me"
var examplevar "and"

Variables in strings can be done as
("String" + examplevar + " Second String");
Or, preferrably
($"String {examplevar} Second String");

//MATH

= "set to"
== "is equal to"
&& "and"
|| "or"

//Conditionals

bool a = true
print($"Control: {a}");

Whitespace, tabs, spaces are insignificant.
{ and } are only if you want more than one statement to be part of result of an "if" statement.

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

while is a loop that works off of conditional statements. it won't execute once if the statement doesn't start out true. whiles require no ; after they're written if there's no "do" written earlier.

counter = 0
while (counter < 10)
counter++;
print(counter)
//1 through 10 is printed. when the counter starts at 10 or higher, nothing is returned.

do is different. do executes the code first and then checks if the condition should loop.

counter = 25
do
{
counter++;
print(counter)
} while counter (<10);
//only 26 is printed. if the counter started at 0 the result would be the same.

for loops have 3 parts

the initialiser: what is the temporary variable we're looping with? int counter = 0;

the condition: the for loop continues as long as this is true. counter < 10

the iterator: how is the variable modified after executing the block in the for statement? counter++

the end result looks like this:

for(int counter = 0; counter < 10; counter++)
{
    print(counter);
}

there is no semicolon at the end of a for loop, just semi colons to separate its 3 parts

here's how to find all numbers divisible by 3 with my own for loop

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