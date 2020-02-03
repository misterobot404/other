#include <iostream>
#include <iomanip>
#include <string>
#include <sstream>
using namespace std;

class FloatPoint
{

private:
	// sign 0 = plus
	// sign 1 = minus
	bool sign = 0;
	string mantis = "";
	int exponent = 0;
	static FloatPoint stringToFPoint(string fPointString)
	{
		// Return value
		FloatPoint fPoint;

		// Определяем знаковый бит числа
		if (fPointString[0] == '-')
		{
			fPoint.sign = 1;
			fPointString.erase(0, 1);
		}

		// Убираем лишние ведущие нули
		while (fPointString[0] == '0'
			&& fPointString.length() != 1 // Следующий элемент за нолём существует
			&& fPointString[1] != '.' // Следующий элемент за нолём не точка
			&& fPointString[1] != ',') // Следующий элемент за нолём не запятая
		{
			fPointString.erase(0, 1);
		}


		bool pointEntry = false;
		//  Расчет экспоненты (количество цифр перед разделяющей точкой)
		for (size_t i = 0; i < fPointString.length() && pointEntry == false; i++)
		{
			if (fPointString[i] == '.' || fPointString[i] == ',')
			{
				pointEntry = true;
				fPointString.erase(i, 1);
				fPoint.exponent = i - 1;
			}

			if (i + 1 == fPointString.length() && pointEntry == false && i > 1)
			{
				pointEntry = true;
				fPoint.exponent = i;
			}
		}

		// Если в числе одни нули
		if (stold(fPointString) == 0) fPointString = '0';

		// Установка точки на новую позицию
		if (pointEntry == true)
		{
			fPointString.insert(1, ".");
		}

		//Смещаем плавающую часть вправо, если челая часть мантисы равна 0
		while (fPointString.length() > 2 && fPointString[0] == '0' && fPointString[1] == '.')
		{
			fPointString.erase(0, 2);
			if (fPointString.length() > 1) fPointString.insert(1, ".");
			fPoint.exponent--;
		}

		fPoint.mantis = fPointString;
		return fPoint;
	};
public:
	FloatPoint& operator = (const FloatPoint& right)
	{
		sign = right.sign;
		mantis = right.mantis;
		exponent = right.exponent;
		return *this;
	}
	friend FloatPoint operator + (const FloatPoint& left, const FloatPoint& right)
	{
		long double value1, value2;

		if (left.sign == 0)
			value1 = stold(left.mantis + "e" + to_string(left.exponent));
		else
			value1 = stold("-" + left.mantis + "e" + to_string(left.exponent));

		if (right.sign == 0)
			value2 = stold(right.mantis + "e" + to_string(right.exponent));
		else
			value2 = stold("-" + right.mantis + "e" + to_string(right.exponent));

		ostringstream streamObj;
		streamObj << setprecision(16);
		//Add double to stream
		streamObj << value1 + value2;
		// Get string from output string stream
		string stringFPoint = streamObj.str();

		return stringToFPoint(stringFPoint);
	}
	friend FloatPoint operator - (const FloatPoint& left, const FloatPoint& right)
	{
		long double value1, value2;

		if (left.sign == 0)
			value1 = stold(left.mantis + "e" + to_string(left.exponent));
		else
			value1 = stold("-" + left.mantis + "e" + to_string(left.exponent));

		if (right.sign == 0)
			value2 = stold(right.mantis + "e" + to_string(right.exponent));
		else
			value2 = stold("-" + right.mantis + "e" + to_string(right.exponent));

		ostringstream streamObj;
		streamObj << setprecision(16);
		//Add double to stream
		streamObj << value1 - value2;
		// Get string from output string stream
		string stringFPoint = streamObj.str();

		return stringToFPoint(stringFPoint);
	}
	friend FloatPoint operator * (const FloatPoint& left, const FloatPoint& right)
	{
		long double value1, value2;

		if (left.sign == 0)
			value1 = stold(left.mantis + "e" + to_string(left.exponent));
		else
			value1 = stold("-" + left.mantis + "e" + to_string(left.exponent));

		if (right.sign == 0)
			value2 = stold(right.mantis + "e" + to_string(right.exponent));
		else
			value2 = stold("-" + right.mantis + "e" + to_string(right.exponent));

		ostringstream streamObj;
		streamObj << setprecision(16);
		//Add double to stream
		streamObj << value1 * value2;
		// Get string from output string stream
		string stringFPoint = streamObj.str();

		return stringToFPoint(stringFPoint);
	}
	friend FloatPoint operator / (const FloatPoint& left, const FloatPoint& right)
	{
		long double value1, value2;

		if (left.sign == 0)
			value1 = stold(left.mantis + "e" + to_string(left.exponent));
		else
			value1 = stold("-" + left.mantis + "e" + to_string(left.exponent));

		if (right.sign == 0)
			value2 = stold(right.mantis + "e" + to_string(right.exponent));
		else
			value2 = stold("-" + right.mantis + "e" + to_string(right.exponent));

		ostringstream streamObj;
		streamObj << setprecision(16);
		//Add double to stream
		streamObj << value1 / value2;
		// Get string from output string stream
		string stringFPoint = streamObj.str();

		return stringToFPoint(stringFPoint);
	}

	friend ostream& operator<< (ostream& out, const FloatPoint& fPoint)
	{
		cout << "Число: ";
		if (fPoint.sign == 0)
			cout << fPoint.mantis << "e" << fPoint.exponent << endl;
		else
			cout << "-" << fPoint.mantis << "e" << fPoint.exponent << endl;

		cout << "Знаковый бит: ";
		if (fPoint.sign == 0)
		{
			cout << fPoint.sign << " (+)" << endl;
		}
		else
		{
			cout << fPoint.sign << " (-)" << endl;
		}
		cout << "Мантиса: " << fPoint.mantis << endl;
		cout << "Экспонента: " << fPoint.exponent << endl;
		cout << endl;

		return out;
	}
	friend istream& operator>> (istream& in, FloatPoint& fPoint)
	{
		string fPointString;
		cin >> fPointString;

		fPoint = stringToFPoint(fPointString);

		return in;
	}
};

int main()
{
	// Устанавливаем язык
	setlocale(LC_ALL, "Russian");
	// Устанавливаем числовую локаль
	setlocale(LC_NUMERIC, "C");

	FloatPoint fPoint1, fPoint2, fPointRes;
	char selectedMenuItem;

	while (true)
	{
		cout << "Арифметика чисел с плавающей точкой" << endl;
		cout << "1 Сложение" << endl;
		cout << "2 Вычитание" << endl;
		cout << "3 Умножение" << endl;
		cout << "4 Деление" << endl;
		cout << "> ";
		cin >> selectedMenuItem;

		switch (selectedMenuItem)
		{
		case '1': {
			cout << "Введите первое число: ";
			cin >> fPoint1;
			cout << "Введите второе число: ";
			cin >> fPoint2;
			cout << endl;

			cout << fPoint1;
			cout << fPoint2;
			cout << endl;

			cout << "Результат сложения" << endl;
			cout << fPoint1 + fPoint2;
		} break;
		case '2': {
			cout << "Введите первое число: ";
			cin >> fPoint1;
			cout << "Введите второе число: ";
			cin >> fPoint2;
			cout << endl;

			cout << fPoint1;
			cout << fPoint2;
			cout << endl;

			cout << "Результат вычитания" << endl;
			cout << fPoint1 - fPoint2;
		} break;
		case '3': {
			cout << "Введите первое число: ";
			cin >> fPoint1;
			cout << "Введите второе число: ";
			cin >> fPoint2;
			cout << endl;

			cout << fPoint1;
			cout << fPoint2;
			cout << endl;

			cout << "Результат умножения" << endl;
			cout << fPoint1 * fPoint2;
		} break;
		case '4': {
			cout << "Введите первое число: ";
			cin >> fPoint1;
			cout << "Введите второе число: ";
			cin >> fPoint2;
			cout << endl;

			cout << fPoint1;
			cout << fPoint2;
			cout << endl;

			cout << "Результат деления" << endl;
			cout << fPoint1 / fPoint2;
		} break;
		default:
			cout << "Ошибка ввода, введите число от 1 до 4" << endl;
			break;
		}

		system("pause");
		system("cls");
	}
	return 0;
}
