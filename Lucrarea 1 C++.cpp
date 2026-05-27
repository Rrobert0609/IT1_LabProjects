#include <iostream>
#include <Windows.h>
using namespace std;
unsigned int nr;//cate afisari pentru jocul de lumini
int a[101];//numerele afisate la jocul de lumini
double x;//primul numar pentru calculator
char semn;//semnul pentru calculator 
static void afis_bin(unsigned int n, int nb)
{
	int i = 0, k = 0;
	char val_b[32];
	if ((n > 0) && (n <= 255))
		k = 8;
	if ((n > 255) && (n <= 65535))
		k = 16;
	if ((n > 65535) && (n <= 2147483646))
		k = 32;
	if (nb > 0)
		k = nb;
	if (n > 2147483646) {
		k = 0;
		cout << "\nNumar prea mare";
	}
	for (i = 0; i < k; i++) {
		if (n % 2 == 0)
			val_b[k - 1 - i] = '0';
		else
			val_b[k - 1 - i] = '1';
		n = n / 2;
	}
	// afisare binara
	for (i = 0; i < k; i++) {
		if (val_b[i] == '0')
			cout << char(176) << " ";
		else
			cout << char(219) << " ";
	}
	// prompter pe prima pozitie
	for (i = 0; i < (2 * k + 1); i++) {
		cout << "\b";
	}
}
void calcul();//ca sa se poata face apelul back and forth
void suma() {
	double y;
	cin >> y;
	cout << x + y;
	char raspuns;
	cout << "\n\nDoriti alt calcul?(Y/N)\n\n";
	cin >> raspuns;
	cout << '\n';
	if (raspuns == 'Y')
		calcul();
	else if (raspuns == 'N') {
		cout << "ok\n";
		return;
	}
	else cout << "Eroare:valoare proasta... ;(\n";
}
void diferenta() {
	double y;
	cin >> y;
	cout << x - y;
	char raspuns;
	cout << "\n\nDoriti alt calcul?(Y/N)\n\n";
	cin >> raspuns;
	cout << '\n';
	if (raspuns == 'Y')
		calcul();
	else if (raspuns == 'N') {
		cout << "ok";
		return;
	}
	else cout << "Eroare:valoare proasta... ;(\n";
}
void produs() {
	double y;
	cin >> y;
	cout << x * y;
	char raspuns;
	cout << "\n\nDoriti alt calcul?(Y/N)\n\n";
	cin >> raspuns;
	cout << '\n';
	if (raspuns == 'Y')
		calcul();
	else if (raspuns == 'N') {
		cout << "ok";
		return;
	}
	else cout << "Eroare:valoare proasta... ;(\n";
}
void impartire() {
	double y;
	cin >> y;
	cout << x / y;
	char raspuns;
	cout << "\n\nDoriti alt calcul?(Y/N)\n\n";
	cin >> raspuns;
	cout << '\n';
	if (raspuns == 'Y')
		calcul();
	else if (raspuns == 'N') {
		cout << "ok";
		return;
	}
	else cout << "Eroare:valoare proasta... ;(\n";
}
void putere() {
	int y;
	double long p = 1;
	cin >> y;
	for (int i = 1; i <= y; i++)
		p *= x;
	cout << p;
	char raspuns;
	cout << "\n\nDoriti alt calcul?(Y/N)\n\n";
	cin >> raspuns;
	cout << '\n';
	if (raspuns == 'Y')
		calcul();
	else if (raspuns == 'N') {
		cout << "ok";
		return;
	}
	else cout << "Eroare:valoare proasta... ;(\n";
}
void calcul() {
	cout << "Introduceti calculul, folosind semnele +,-,*,/,^(ridicare la putere)\nPuneti un spatiu dupa fiecare numar si dupa semn\nDoar un calcul odata este disponibil ;)\n\n";
	cin >> x >> semn;
	switch (semn) {
	case '+':
		suma();
		break;
	case '-':
		diferenta();
		break;
	case '*':
		produs();
		break;
	case '/':
		impartire();
		break;
	case '^':
		putere();
		break;
	}
}
int main() {
	int decizie;
	cout << "Pentru joc de lumini introduceti numarul 1\nPentru calculator introduceti 2\n\n";
	cin >> decizie;
	cout << '\n';
	if (decizie == 1) {
		cout << "Introduceti numarul de pasi pentru joc\n\n";
		cin >> nr;
		cout << '\n';
		for (int i = 1; i <= nr; i++) {
			cout << "Introduceti numarul " << i<<"\n\n";
			cin >> a[i];
		}
		for (int i = 1; i <= nr; i++) {
			afis_bin(a[i],0);
			Sleep(200);
		}
		return 0;
	}
	else if (decizie == 2)
		calcul();
	else cout << "Eroare:valoare proasta... ;(\n";
	return 0;
}