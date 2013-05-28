// g++ Ordenado.cpp -o Ordenado.exe -std=c++11 && ./Ordenado.exe

#include <iostream>
#include <vector>

using namespace std;


bool Ordenado(vector<int>& v) {

  if(v.size() <= 1)
    return true;

  int ultimo = v.back();
  v.pop_back();
  int penultimo = v.back();

  if(ultimo > penultimo)
    return Ordenado(v);
  else
    return false;
}


int main() {
  //vector<int> v = {4, 5, 2, 10, 3, 7};
  vector<int> v = {2, 3, 4, 5, 7, 10};
  bool b = Ordenado(v);

  cout << "O vetor de elementes esta ordenado: " << (b ? "sim" : "nao") << endl;

  return 0;
} 