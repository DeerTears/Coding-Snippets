/* function declaration */
int foo(int bar);

int main() {
    /* calling foo from main */
    printf("The value of foo is %d", foo(1));
}

int foo(int bar) {
    return bar + 1;
}

/*function that does not return a value has to be void*/

void moo() {
    /* do something and don't return a value */
}

int main() {
    moo();
}