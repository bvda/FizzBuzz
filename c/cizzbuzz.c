#include <stdio.h>

int main() {
  FILE* f = open("out.log", "r");
  for(int i = 0; i <= 15; ++i) {
    if (i % 3 == 0) {
      printf("Fizz");
      fprintf(f, "Fizz");
    }
    if (i % 5 == 0) {
      printf("Buzz");
      fprintf(f, "Buzz");
    }
    if ((i % 3 != 0) && (i % 5 != 0)) {
      printf("%d", i);
      fprintf(f, "%d", i);
    }
    printf("\n");
  }
  return 0;
}

FILE* open(const char* path, const char* mode) {
  fopen(path, mode);
}

// Hint: Check out https://man7.org/linux/man-pages/man3/fopen.3.html