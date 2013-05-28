// g++ SomaNumeros.cpp -o SomaNumeros.exe -std=c++11 && ./SomaNumeros.exe

#include <iostream>
#include <vector>

using namespace std;


int SomaNumeros(vector<int>& v) {

  if(v.size() == 0)
    return 0;

  int ultimo = v.back();
  v.pop_back();

  return ultimo + SomaNumeros(v);
}


int main() {
  // c++03
  //int nums[] = {4, 5, 2, 10, 3, 7};
  //vector<int> v(nums, nums + sizeof(nums) / sizeof(int));
  // c++11
  vector<int> v = {4, 5, 2, 10, 3, 7};

  int somatoria = SomaNumeros(v);

  cout << "A soma dos elementos do vetor é " << somatoria << endl;

  return 0;
} 