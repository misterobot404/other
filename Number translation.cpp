// ���������� ���������� ��� ������ � �������� �����/������ (cin/cout)
#include <iostream>
// ���������� ���������� ��� ������ �� ��������
#include <string>
// ������������� ������������ ���� std
using namespace std;

// ��������� ������� getSymbol � ������������ ��������� ���� string. ������� ��������� �������� ����� � ���������(��) �������.
string getSymbol(int num, string hi, string re, string lo);

// ������� main. ����� ����� � ���������.
int main() {
	// ������������� ������� ������ ��� ����������� ����������� ��������� � �������
	setlocale(LC_ALL, "rus");
	// ����������� ���� ��� ���������� ����������� ����
	while (true)
	{
		// ���������� size_t ��� �������� �������� ������ ������ ���� �������������. size_t - ������������� ��� ������ ��� �����.
		size_t select;
		// cout - ����� ������ �� �������. endl - ������� ������, ������� ������� � ������ ������.
		cout << "1. ������� ������� � ��������." << endl;
		cout << "2. ������� �������� � �������." << endl;
		cout << "> ";
		// cin - ������ ����������� ������ ����� � ���������� select
		cin >> select;
		// ������� ������
		cout << endl;
		// ���� select ����� 1
		if (select == 1) {
			// ������ ����� �������� ��� �������� ��������� �����
			char lat[100];
			// ������������� ���������� ��� �������� ���������� �������� �����
			int count = 0;
			cout << "������� ������� ����� �� ������ MMMCMXCIX: ";
			// ������� ���������� ����� �����
			cin.ignore();
			// ��������� �� ������ 100 ��������
			cin.getline(lat, 100);
			// ���� �� 0 �� ���������� ������� ������ lat
			for (int i = 0; i < strlen(lat); i++) {
				// ���������� �������� �������� ��������� switch ��� ����������� �������� lat[i]
				switch (lat[i]) {
					// ���� lat[i] ����� lat[i]
				case 'M':
					// ���������� � ��������� ����� count 1000
					count += 1000;
					// ��������� ���������� switch
					break;
					// ��. ����.
				case 'D':
					count += 500;
					break;
				case 'C':
					// ���� 'C' ����� �� ������������� � ���� ��������� ������� ����� 'D' ��� 'M', ����� �� ���������� �������� 100
					if (i + 1 < strlen(lat) && (lat[i + 1] == 'D' || lat[i + 1] == 'M')) count -= 100;
					// � ��������� ������ ���������� � ���������� 100
					else count += 100;
					break;
					// ��. ����.
				case 'L':
					count += 50;
					break;
					// ��. ����.
				case 'X':
					if (i + 1 < strlen(lat) && (lat[i + 1] == 'L' || lat[i + 1] == 'C' || lat[i + 1] == 'M')) count -= 10;
					else count += 10;
					break;
					// ��. ����.
				case 'V':
					count += 5;
					break;
					// ��. ����.
				case 'I':
					if (i + 1 < strlen(lat) && (lat[i + 1] == 'V' || lat[i + 1] == 'X' || lat[i + 1] == 'C')) count -= 1;
					else count += 1;
					break;
				}
			}
			// ������� ��������� �������� �������� ����� � ��������
			cout << count << endl << endl;
		}
		// ���� select ����� 2
		else if (select == 2) {
			// ��. ����.
			cout << "������� �������� ����� �� ������ 3999: ";
			// ������������� ���������� ��� �������� ��������� �����
			int arabien_num;
			// ���� ���������� ������� �� ����� ��� � �������� ������ ����������� ��������� �������� (3999), ��������� ������� ����� � ������������ � ����
			if (!(cin >> arabien_num) || (arabien_num > 3999)) {
				cerr << "���������� ���������������� �����!" << endl;
				// ������� � ��������� �������� �������� �����
				continue;
			}
			// �������� ��������� �������� �����
			string rome_num;
			// ������� ������� � ������� ������� � ���������� �� � ��������� �����
			rome_num += getSymbol(arabien_num / 1000, "", "", "M");
			// ��������� �������� ����� �� ��������� �����
			arabien_num %= 1000;
			// ������� ������ � ������� ������� � ���������� �� � ��������� �����
			rome_num += getSymbol(arabien_num / 100, "M", "D", "C");
			// ��������� ����� ����� �� ��������� �����
			arabien_num %= 100;
			// ������� �������� � ������� ������� � ���������� �� � ��������� �����
			rome_num += getSymbol(arabien_num / 10, "C", "L", "X");
			// ��������� ������� ����� �� ��������� �����
			arabien_num %= 10;
			// ������� ������ � ������� ������� � ���������� �� � ��������� �����
			rome_num += getSymbol(arabien_num, "X", "V", "I");
			// ������� �������� ������� �����
			cout << rome_num << endl << endl;
		}
		// ���� �������� �����-�� ������ �������� ������� �� ���������
		else break;
	}
	// ���������� ������� windows ��� ��������� ����������
	system("pause");
	// ���������� �������� �� �������� ������� main. ��������� ������ ���������.
	return 0;
}

// �������� ������� �������� ��������� ������� � ������. � ����������� �� ������� ��������� ����� hi, re � lo ����� ��������.
string getSymbol(int num, string hi, string re, string lo)
{
	// ��. ����.
	switch (num)
	{
	// ���� �������� ������ ����� 9
	case 9:
		// ���������� ��������� lo + hi.
		// hi, re, lo ������� ������� ���������� �� ����������.
		return lo + hi;
	// ��. ����.
	case 8:
		return re + lo + lo + lo;
	case 7:
		return re + lo + lo;
	case 6:
		return re + lo;
	case 5:
		return re;
	case 4:
		return lo + re;
	case 3:
		return lo + lo + lo;
	case 2:
		return lo + lo;
	case 1:
		return lo;
	// ���� �������� ������ ����� 0, ��������� ������ ������.
	case 0:
		return "";
	}
}