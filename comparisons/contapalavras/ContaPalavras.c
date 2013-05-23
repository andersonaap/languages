#include <stdio.h>
#include <ctype.h>


#define TRUE 1



int contarPalavras(const char * frase) {

	int quantidadePalavras = 0;
	int posicaoCaracter = 0;
	char caracterAnterior = ' ';

	while(TRUE) {
		char caracterAtual = frase[posicaoCaracter];

		if(caracterAtual == '\0')
			break;

		if(!isalpha(caracterAnterior) && isalpha(caracterAtual))
			quantidadePalavras++;

		caracterAnterior = caracterAtual;
		posicaoCaracter++;
	}

	return quantidadePalavras;
}

int main() {
	char frase[1024];
	int quantidadePalavras;

	printf("Digite uma frase\n");

	// http://stackoverflow.com/questions/6282198/reading-string-from-input-with-space-character
	scanf("%[^\n]s", frase); 
 
	quantidadePalavras = contarPalavras(frase);
 
	printf("A frase tem %d palavras.\n", quantidadePalavras);

	return 0;
}
