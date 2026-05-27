#include <iostream>
using namespace std;
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
}
int main() {
	int v[] = { 102,153,129,66,36,24 };
	for (int i = 0; i < 6; i++) {
		afis_bin(v[i], 8);
		cout << '\n';
	}
}