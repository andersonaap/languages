#include <iostream>
#include <iterator>
#include <algorithm>
#include <numeric>
#include <vector>
using namespace std;

int main()
{
	vector<int> lista(100);	
	int i = 0;	for_each(lista.begin(), lista.end(), [&](int& x) { x = ++i; } );
	auto beginIt = lista.begin(), endIt = lista.end();


	endIt = remove_if(beginIt, lista.end(), [](int& x) { return !((x % 2) == 0); });
	transform(beginIt, endIt, beginIt, [](int& x) { return x * x; });
	auto somaDosParesAoQuadrado = accumulate(beginIt, endIt, 0, [](int& acc, int& x) { return acc + x; });


	cout << somaDosParesAoQuadrado << endl; 
	return 0;
}
