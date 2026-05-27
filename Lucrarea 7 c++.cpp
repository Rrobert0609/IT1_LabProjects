#include <iostream>
using namespace std;
struct tranz_bursa {
	string nume_actiune;
	int val_min, val_max, val_desch, val_inch;
	tranz_bursa() {
		nume_actiune = "Samsung";
		val_min = 213;
		val_max = 965;
		val_desch = 367;
		val_inch = 842;
	}
	tranz_bursa(string nume, int min, int max, int desch, int inch) {
		nume_actiune = nume;
		val_min = min;
		val_max = max;
		val_desch = desch;
		val_inch = inch;
	}
};
int main() {
	tranz_bursa samsung;
	tranz_bursa apple;
	cin >> apple.nume_actiune >> apple.val_min >> apple.val_max >> apple.val_desch >> apple.val_inch;
	cout << "Exemplu:\nNume: " << samsung.nume_actiune << "\nValoare minima: " << samsung.val_min << "\nValoare maxima: " << samsung.val_max << "\nValoare deschidere: " << samsung.val_desch << "\nValoare inchidere: " << samsung.val_inch;
	cout << "\n\nBursa:\nNume: " << apple.nume_actiune << "\nValoare minima: " << apple.val_min << "\nValoare maxima: " << apple.val_max << "\nValoare deschidere: " << apple.val_desch << "\nValoare inchidere: " << apple.val_inch;
}