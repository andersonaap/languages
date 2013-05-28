/* gcc SomaNumeros.c -o SomaNumeros.exe -ansi && ./SomaNumeros.exe */

#include <stdio.h>


int SomaNumeros(int * atual, int * ultimo) {

  if(atual == ultimo)
    return *ultimo;

  int * proximo = &atual[1];

  return *atual + SomaNumeros(proximo, ultimo);
}



int main() {

  int vetor[] = {4, 5, 2, 10, 3, 7};
  int primeiro = 0;
  int ultimo = sizeof(vetor) / sizeof(int) - 1;
  int somatoria = SomaNumeros(&vetor[primeiro],  &vetor[ultimo]);

  printf("A soma dos elementos do vetor é %d\n", somatoria);

  return 0;
}