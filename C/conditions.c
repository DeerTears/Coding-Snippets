#include <stdio.h>

int main(){
	int test = 10;
	int target = 10;
		if (test == target) {
			printf("Test and target are equal to %i", target)
		}
}

//new script

#include <stdio.h>

int main() {
    guessNumber(500);
    guessNumber(600);
    guessNumber(555);
}

void guessNumber(int guess) {
    if (guess == 555) {
        printf("Correct. You guessed it! ");
    } else if (guess < 555) {
        printf("Your guess is too high. ");
    } else if (guess > 555) {
        printf("Your guess is too low. ");
	}
}
