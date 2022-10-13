#include <stdio.h>
#include <stdlib.h>

FILE* open(const char* path, const char* mode);

int main(const int argc, char** argv) {
  FILE* f = open(argv[3], "w");
  for(int i = atoi(argv[1]); i <= atoi(argv[2]); ++i) {
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
    fprintf(f, "\n");
  }
  return 0;
}

FILE* open(const char* path, const char* mode) {
  return fopen(path, mode);
}
