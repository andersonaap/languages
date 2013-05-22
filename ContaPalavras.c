#include <stdio.h>
 
#define BOOL int
#define TRUE 1
#define FALSE 0
 
 
BOOL ehLetra(const char caracter) {
	char caracterCaixaBaixa = 0x20 | caracter;
	if(caracterCaixaBaixa >= 'a' && caracterCaixaBaixa <= 'z')
		return TRUE;
	return FALSE;
}
 
int contarPalavras(const char * frase) {
 
	int quantidadePalavras = 0;
	int posicaoCaracter = 0;
	char caracterAnterior = ' ';
 
	while(TRUE) {
		char caracterAtual = frase[posicaoCaracter];
 
		if(caracterAtual == '\0')
			break;
 
		if(!ehLetra(caracterAnterior) && ehLetra(caracterAtual))
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
	scanf("%[^\n]s", &frase); 
 
	quantidadePalavras = contarPalavras(frase);
 
	printf("A frase tem %d palavras", quantidadePalavras);
 
	return 0;
}
