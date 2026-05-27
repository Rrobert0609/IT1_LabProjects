#include <iostream>
#include <algorithm>
using namespace std;
int n, v[101], nrCautat, aux;
void citire() {
	if (aux) {
		cout << "Introduceti numarul " << n-aux+1 << ": ";
		cin >> v[n-aux+1];
		aux--;
		citire();
	}
	return;
}
void cautare_binara(int nr, int a[101], int aux) {
	int s = 1, d = nr;
	while (d >= s) {
		if (a[(d+s) / 2] == aux) {
			cout << "Numarul apare in sir pe pozitia "<<(d+s)/2<<'.';
			return;
		}
		if (a[(d + s) / 2] < aux)
			s = (d + s) / 2 + 1;
		else
			d = (d + s) / 2 - 1;
	}
	cout << "Numarul nu apare in sir.";
}
int main() {
	cout << "Introduceti marimea sirului de numere (limita de 100 de numere): ";
	cin >> n;
	aux = n;
	citire();
	sort(v + 1, v + n + 1);
	cout << "Sirul sortat arata asa:\n";
	for (int i = 1; i <= n; i++)
		cout << v[i] << ' ';
	cout << '\n';
	cout << "Vedeti daca un numar apare in sir.\nIntroduceti numarul cautat: ";
	cin >> nrCautat;
	cautare_binara(n, v, nrCautat);
	return 0;
}