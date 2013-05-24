/* gcc ContaPalavras.c -o ContaPalavras.exe */

#include <stdio.h>
#include <ctype.h>


int contarPalavras(const char * frase) {
	int quantidadePalavras = 0;
	int posicaoCaracter;
	char caracterAnterior = ' ';
	char caracterAtual;

	for(posicaoCaracter = 0; caracterAtual = frase[posicaoCaracter], caracterAtual != '\0'; posicaoCaracter++) {

		if(!isalpha(caracterAnterior) && isalpha(caracterAtual))
			quantidadePalavras++;

		caracterAnterior = caracterAtual;
	}

	return quantidadePalavras;
}

int main() {
	char frase[1024];
	int quantidadePalavras;

	printf("Digite uma frase\n");

	/* http://stackoverflow.com/questions/6282198/reading-string-from-input-with-space-character */
	scanf("%[^\n]s", frase); 
 
	quantidadePalavras = contarPalavras(frase);
 
	printf("A frase tem %d palavras.\n", quantidadePalavras);

	return 0;
}
