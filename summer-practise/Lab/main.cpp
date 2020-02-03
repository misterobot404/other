#include "SummerPractise.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	int select;
	while (true)
	{
		system("cls");
		cout << "Главное меню:" << endl;
		cout << " Задание 1" << endl;
		cout << " Задание 2" << endl;
		cout << " Задание 3" << endl;
		cout << " Задание 4" << endl;
		cout << " Задание 5" << endl;
		cout << " Задание 6" << endl;
		cout << " Задание 7" << endl;
		cout << " Задание 8" << endl;
		cout << " Задание 9" << endl;
		cout << " Задание 10" << endl;
		cout << "Введите номер задания (или 0 для выхода): ";
		cin >> select;
		switch (select)
		{
		case 1:
		{
			system("cls");
			cout << "Задание 1" << endl;
			cout << "Описание задания: вывод в консоль строк из n-количества символов" << endl << endl;

			char symbol;
			cout << "Введите символ: "; cin >> symbol;
			unsigned int countSymbol;
			cout << "Введите количество символов в строке: "; cin >> countSymbol;
			unsigned int countLine;
			cout << "Введите количество cтрок: "; cin >> countLine;
			SummerPractise::task1(symbol, countSymbol, countLine);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 2:
		{
			system("cls");
			cout << "Задание 2" << endl;
			cout << "Описание задания: вывод в консоль чисел от нуля до number (число от пользователя)" << endl << endl;

			int number;
			cout << "Введите число: "; cin >> number;
			SummerPractise::task2(number);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 3:
		{
			system("cls");
			cout << "Задание 3" << endl;
			cout << "Описание задания: вывод в консоль всех чисел из диапазона" << endl << endl;

			int start;
			cout << "Введите начало диапазона: "; cin >> start;
			int end;
			cout << "Введите конец диапазона: "; cin >> end;
			SummerPractise::task3(start, end);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 4:
		{
			system("cls");
			cout << "Задание 4" << endl;
			cout << "Описание задания: вывод в консоль всех чётных чисел из диапазона" << endl << endl;

			int start;
			cout << "Введите начало диапазона: "; cin >> start;
			int end;
			cout << "Введите конец диапазона: "; cin >> end;
			SummerPractise::task4(start, end);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 5:
		{
			system("cls");
			cout << "Задание 5" << endl;
			cout << "Описание задания: вывод в консоль всех нечётных чисел из диапазона" << endl << endl;

			int start;
			cout << "Введите начало диапазона: "; cin >> start;
			int end;
			cout << "Введите конец диапазона: "; cin >> end;
			SummerPractise::task5(start, end);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 6:
		{
			system("cls");
			cout << "Задание 6" << endl;
			cout << "Описание задания: вывод в консоль количества цифр в числе number (число от пользователя)" << endl << endl;

			int number;
			cout << "Введите число: "; cin >> number;
			SummerPractise::task6(number);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 7:
		{
			system("cls");
			cout << "Задание 7" << endl;
			cout << "Описание задания: вывод в консоль реверс числа" << endl << endl;

			int number;
			cout << "Введите число: "; cin >> number;
			SummerPractise::task7(number);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 8:
		{
			system("cls");
			cout << "Задание 8" << endl;
			cout << "Описание задания: вывод в консоль результат возведения числа в степень" << endl << endl;

			double number;
			cout << "Введите число: "; cin >> number;
			double degree;
			cout << "Введите степень (отрицательные степени поддерживаются): "; cin >> degree;
			SummerPractise::task8(number, degree);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 9:
		{
			system("cls");
			cout << "Задание 9" << endl;
			cout << "Описание задания: вывод в консоль длины гепотенузы прямоугольного треугольника по длинам катетов" << endl << endl;

			unsigned int lineLength1;
			cout << "Введите длину первого катета: "; cin >> lineLength1;
			unsigned int lineLength2;
			cout << "Введите длину второго катета: "; cin >> lineLength2;
			SummerPractise::task9(lineLength1, lineLength2);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 10:
		{
			system("cls");
			cout << "Задание 10" << endl;
			cout << "Описание задания: вывод в консоль расстояние между двумя точками в пространстве (x,y,z)" << endl << endl;

			Point point1;
			cout << "Ввод координат первой точки" << endl;
			cout << "x: "; cin >> point1.x;
			cout << "y: "; cin >> point1.y;
			cout << "z: "; cin >> point1.z;
			cout << endl;

			Point point2;
			cout << "Ввод координат второй точки" << endl;
			cout << "x: "; cin >> point2.x;
			cout << "y: "; cin >> point2.y;
			cout << "z: "; cin >> point2.z;
			cout << endl;

			SummerPractise::task10(point1, point2);
			cout << endl;

			cout << "Для возвращения в главное меню нажмите любую клавишу...";
			cin.ignore(); cin.get();
		}
			break;
		case 0:
			return 0;
		default:
			system("cls");
			break;
		}
	}
}
