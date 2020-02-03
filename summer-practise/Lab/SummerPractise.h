#pragma once

struct Point;

class SummerPractise
{
public:
	/* Вывод в консоль строк из символов */
	static void task1(char symbol, unsigned int countSymbol, unsigned int countLines);
	/* Вывод в консоль чисел от нуля до number */
	static void task2(int number);
	/* Вывод в консоль всех чисел из диапазона */
	static void task3(int start, int end);
	/* Вывод в консоль всех четных чисел из диапазона */
	static void task4(int start, int end);
	/* Вывод в консоль всех нечетных чисел из диапазона */
	static void task5(int start, int end);
	/* Вывод в консоль количества цифр в числе number */
	static void task6(int number);
	/* Вывод в консоль реверс числа number */
	static void task7(int number);
	/* Вывод в консоль степень числа number (учитываются отрицательные степени) */
	static void task8(double number, double degree);
	/* Вывод в консоль длины гепотенузы прямоугольного треугольника по длине катетов */
	static void task9(double sideLength1, double sideLength2);
	/* Вывод в консоль расстояние между двумя точками в пространстве (x,y,z) */
	static void task10(Point point1, Point point2);
};

struct Point
{
	double x;
	double y;
	double z;
};
