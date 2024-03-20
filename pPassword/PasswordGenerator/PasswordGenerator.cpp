#include <iostream>
#include <fstream>
#include <string>
#include <ctime>

using namespace std;

string generatePassword() {
	srand(time(NULL));
	string password = "";
	int lowLetters = 0;
	int highLetters = 0;
	int digits = 0;
	int specials = 0;

	for (int i = 0; i < 16; i++) {
		char code = (rand() % 94 + 33);
		char next = code;
		
		if (code >= 48 && code <= 57 && digits < 5) {
			password += next;
			digits++;
		}
		else if (code >= 64 && code <= 90 && highLetters < 4) {
			password += next;
			highLetters++;
		}
		else if (code >= 97 && code <= 122 && lowLetters < 4) {
			password += next;
			lowLetters++;
		}
		else if (((code == 33) || (code >= 35 && code <= 43) || (code >= 45 && code <= 47)) && specials < 4) {
			password += next;
			specials++;
		}
		else {
			i--;
		}
	}

	return password;
}

int main()
{
	string password;
	string oldpassword;
	string input = "y";

	cout << "pPassword (v1.1) - D. Preston Peek\n";
	cout << "Press 'Enter' to generate a 16-character password.";
	cin.get();
	while (input == "y") {
		while (password == generatePassword());
		password = generatePassword();
		cout << password << endl << endl;
		cout << "Another? (y/n)";
		cin >> input;
	}
	cin.get();
	return 0;
}
