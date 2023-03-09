#include <iostream>
using namespace std;

int main()
{
	string symb;
	string option;
	double num1;
	double num2;

	do {
		cout << "    Zahl 1| ";
		cin >> num1;

		cout << "+ - * / % | ";
		cin >> symb;

		cout << "    Zahl 2| ";
		cin >> num2;

		cout << "The sum is : ";
		if (symb == "+")
		{
			cout << num1 + num2;
		}
		else if(symb == "-") {
			cout << num1 - num2;
		}
		else if (symb == "*") {
			cout << num1 * num2;
		}
		else if (symb == "/") {
			cout << num1 / num2;
		}
		else if (symb == "%") {
			cout << int (num1) % int (num2);
		}
		else {
			cout << "ERROR";
		}
		cout << endl;
		cout << "(E)xit | (R)erun" <<endl;
		cout << "-------------------" << endl; 
		cin >> option;
	} while (option == "r" || option == "R");
	return 0;
}