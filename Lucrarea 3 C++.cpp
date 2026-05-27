#include <iostream>
using namespace std;
int main() {
	int x, y, contor_spatii = 0;
	cout << "Generare tabla inmultirii cu limitele superioare variabile.\nIntroduceti cele doua limite superioare:";
	cin >> x >> y;
	int cevacevaextra = x * y;
	while (cevacevaextra) {
		contor_spatii++;
		cevacevaextra /= 10;
	}
	contor_spatii++;
	for (int aux = contor_spatii; aux > 0; aux--)
		cout << ' ';
	cout << '\t';
	for (int i = 1; i <= x; i++) {
		cout << i;
		int aux = i,altcontor=contor_spatii;
		while (aux) {
			altcontor--;
			aux /= 10;
		}
		for (altcontor; altcontor > 0; altcontor--)
			cout << ' ';
	}
	for (int aux = contor_spatii; aux > 0; aux--)
		cout << '\n';
	for (int i = 1; i <= x; i++) {
		int altaux = i, altcontor = contor_spatii;
		while (altaux) {
			altcontor--;
			altaux /= 10;
		}
		cout << i;
		for (altcontor; altcontor > 0; altcontor--)
			cout << ' ';
		cout << '\t';
		for (int j = 1; j <= y; j++) {
			cout << i * j;
			int incaunaux = i * j, altcontor = contor_spatii;
			while (incaunaux) {
				altcontor--;
				incaunaux /= 10;
			}
			for (altcontor; altcontor > 0; altcontor--)
				cout << ' ';
		}
		cout << '\n';
	}
	return 0;
}