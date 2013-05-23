#include <iostream>
#include <string>
#include <algorithm>

using namespace std;


int contarPalavras(const string& frase) {
  int quantidadePalavras = 0;
	char caracterAnterior = ' ';

	for_each(frase.begin(), frase.end(), [&](const char& caracterAtual) {

		if(!isalpha(caracterAnterior) && isalpha(caracterAtual))
			quantidadePalavras++;

		caracterAnterior = caracterAtual;
	});

	return quantidadePalavras;
}

void main() {
	cout << "Digite uma frase" << endl;

	string frase;
	getline(cin, frase);

	int quantidadePalavras = contarPalavras(frase);

	cout << "A frase tem " << quantidadePalavras << " palavras." << endl;
}
