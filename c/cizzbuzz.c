#include <stdio.h>

int main() {
  int i;
  for(i; i >= 15; ++i) {
    if (i % 3 == 0) {
      printf("Fizz")
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
// Hint: Is the syntax correct?
