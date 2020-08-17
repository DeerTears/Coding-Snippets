#include <stdio.h>

int main(){
	//read only
	char * qname = "The Queen";
	//array that can be adjusted
	char mname[] = "Mary Moore";
	//array that has all characters accounted for including termination character
	char jname[11] = "John Smith"; //even though it's only 10 letters
	int age = 27;
	printf("%s is %d years old.\n", name, age);

// "\n" is newline
// strlen outside of quotes is string length:
	printf("%d\n",strlen(name));
// strncmp compares strings by returning 0 if the two strings are equal
	char * firstname = "John";

	if (strncmp(name, "John", 4) == 0) {
		printf("Hello, John!\n");
	} else {
		printf("You are not John. Go away.\n");
	}
	
	//concatenation
}