#include <stdio.h>
//#define bool char //this might be wrong lmao
//#define TRUE 1
//#define FALSE 0

int main() {
	//we use the integer type to define the variables in the array:
	char vowels[2][5] = {
		{'A', 'E', 'I', 'O', 'U'},
		{'a', 'e', 'i', 'o', 'u'}
	//[row][column]
	//the row value isn't needed
	//so long as we include the # of columns
int keypad [4][3] = {
	{1, 2 ,3} ,
	{4, 5, 6} ,
	{7, 8, 9} ,
	{10, 0, 11}
};

//the above 2D array is identical to the following one:

int keypadsimple [4][3] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 11};

//if we want to call upon anything in these arrays, we just pick the row/column it's indexed in (with zero-indexing)

int five = keypad[1][1]

