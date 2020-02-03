#include "SummerPractise.h"
#include <iostream>
using namespace std;

void SummerPractise::task1(char symbol, unsigned int countSymbol, unsigned int countLines)
{
	cout << "Результат: " << endl;
	for (size_t i = 0; i < countLines; i++)
	{
		for (size_t j = 0; j < countSymbol; j++)
		{
			cout << symbol;
		}
		cout << endl;
	}
}

void SummerPractise::task2(int number)
{
	cout << "Результат: ";
	if (number < 0)
	{
		for (int i = 0; number != i; i--)
		{
			cout << i << " ";
		}
		cout << endl;
	}
	else
	{
		for(int i = 0; number != i; i++)
		{
			cout << i << " ";
		}
		cout << endl;
	}
}

void SummerPractise::task3(int start, int end)
{
	cout << "Результат: ";
	if (start < end)
	{
		for (; start <= end; start++)
		{
			cout << start << " ";
		}
	}
	else
	{
		for (; start >= end; start--)
		{
			cout << start << " ";
		}
	}
	cout << endl;
}

void SummerPractise::task4(int start, int end)
{
	cout << "Результат: ";
	if (start < end)
	{
		for (; start <= end; start++)
		{
			if (start % 2 == 0)
			{
				cout << start << " ";
			}
		}
	}
	else
	{
		for (; start >= end; start--)
		{
			if (start % 2 == 0)
			{
				cout << start << " ";
			}
		}
	}
	cout << endl;
}

void SummerPractise::task5(int start, int end)
{
	cout << "Результат: ";
	if (start < end)
	{
		for (; start <= end; start++)
		{
			if (start % 2 != 0)
			{
				cout << start << " ";
			}
		}
	}
	else
	{
		for (; start >= end; start--)
		{
			if (start % 2 != 0)
			{
				cout << start << " ";
			}
		}
	}
	cout << endl;
}

void SummerPractise::task6(int number)
{
	int i = 0;
	for (; number > 0; i++) 
	{
		number /= 10;
	}
	cout << "Результат: " << i << endl;
}

void SummerPractise::task7(int number)
{
	int revNum = 0;

	while (number) {
		revNum = revNum * 10 + number % 10;
		number /= 10;
	}

	cout << "Результат: " << revNum << endl;
}

void SummerPractise::task8(double number, double degree)
{
	cout << "Результат: " << pow(number, degree) << endl;
}

void SummerPractise::task9(double sideLength1, double sideLength2)
{
	cout << "Результат: " << sqrt(sideLength1 * sideLength1 + sideLength2 * sideLength2) << endl;
}

void SummerPractise::task10(Point point1, Point point2)
{
	cout << "Результат: " << sqrt(
		pow((point1.x - point2.x),2) + 
		pow((point1.y - point2.y), 2) + 
		pow((point1.z - point2.z), 2)) 
		<< endl;
}
