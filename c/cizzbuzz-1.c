#include <stdio.h>

int main() {
  for(int i = 0; i <= 100; ++i) {
    if (i % 3 == 0) {
      printf("Fizz");
    }
    if (i % 5 == 0) {
      printf("Buzz");
    }
    if ((i % 3 != 0) && (i % 5 != 0)) {
      printf("%d", i);
    }
  }
  return 0;
}

// Build from CLI: gcc cizzbuzz.c -o cizzbuzz
// Hint: Are all variables initialized correctly?
// Nope. The variable `i` is not initialized and the comparison operator in the loop should be less than rather than greater than.
// Hint: Is the syntax correct?
// Nope. Missing semicolon in line 6.
