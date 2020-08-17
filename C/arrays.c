#include <stdio.h>
#define BOOL char
#define FALSE 0
#define TRUE 1

int main(){
	int numbers[10];
	numbers[0] = 10;
	numbers[1] = 20;
	numbers[2] = 30;
	numbers[3] = 40;
	numbers[4] = 50;
	numbers[5] = 60;
	numbers[6] = 70;
	printf("The 7th number in the array is %d", numbers[6]);
}
