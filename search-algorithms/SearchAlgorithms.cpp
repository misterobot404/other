/*
 Реализовать алгоритмы линейного, бинарного, интерполирующего поиска,
 указать их сложности, сравнить работу алгоритмов на практике.
*/
#include <iostream>
#include <iomanip>
#include <ctime>
#include <time.h>
using namespace std;

//прототипы функций
int linSearch(int arr[], int requiredKey, int size); // линейный поиск
int Search_Binary(int arr[], int left, int right, int key); // бинарный поиск
int interpolatingSearch(int a[], int arraySize, int keyOfSearch); // трилинейный поиск
void showArr(int arr[], int size); // показ массива

int main()
{
	setlocale(LC_ALL, "rus");
	const int arrSize = 160;
	int arr[arrSize];
	int requiredKey = 0; // искомое значение (ключ)
	int nElement = 0; // номер элемента массива
	clock_t start, stop; // хранение времени
	srand(time(NULL));

	//запись случ. чисел в массив от 1 до 50
	for (int i = 0, iterNubmer = 0; i < arrSize; i++, iterNubmer += 50)
	{
		arr[i] = iterNubmer + rand() % 50;
	}

	showArr(arr, arrSize);

	while (true)
	{
		cout << "\nКакое число необходимо искать? ";
		cin >> requiredKey; // ввод искомого числа
		cout << "Введите номер алгоритма поиска:" << endl;
		cout << "1.Линейный поиск (сложность O(n))" << endl;
		cout << "2.Бинарный поиск (сложность O(log2(n))" << endl;
		cout << "3.Интерполирующий поиск (сложность в среднем log(log(N))" << endl;
		cout << "> ";
		int numberMenu = 0;
		cin >> numberMenu;
		switch (numberMenu) {
		case 1:
		{
			start = clock();
			//поиск искомого числа и запись номера элемента
			nElement = linSearch(arr, requiredKey, arrSize);
			if (nElement != -1)
			{
				//если в массиве найдено искомое число - выводим индекс элемента на экран
				cout << "Значение " << requiredKey << " находится в ячейке с индексом: " << nElement << endl;
			}
			else
			{
				//если в массиве не найдено искомое число
				cout << "В массиве нет такого значения" << endl;
			}
			stop = clock();
			cout << "Времени потребовалось " << 1000.0 * (stop - start) / CLOCKS_PER_SEC << " ms\n";

		}
		break;
		case 2:
		{
			start = clock();
			//поиск искомого числа и запись номера элемента
			nElement = Search_Binary(arr, 0, arrSize, requiredKey);
			if (nElement >= 0)
			{
				//если в массиве найдено искомое число - выводим индекс элемента на экран
				cout << "Значение " << requiredKey << " находится в ячейке с индексом: " << nElement << endl;
			}
			else
			{
				//если в массиве не найдено искомое число
				cout << "В массиве нет такого значения" << endl;
			}
			stop = clock();
			cout << "Времени потребовалось " << 1000.0 * (stop - start) / CLOCKS_PER_SEC << " ms\n";
		}
		break;
		case 3:
		{
			start = clock();
			//вызываем функцию интерполирующего поиска
			//сохраняем, возвращенное ею значение, в переменную result
			int result = interpolatingSearch(arr, arrSize, requiredKey);
			if (result != -1)
				//если в массиве найдено искомое число - выводим индекс элемента на экран
				cout << "Значение " << requiredKey << " находится в ячейке с индексом: " << result << endl;
			else
				//значение не найдено
				cout << "В массиве нет такого значения" << endl;
			stop = clock();
			cout << "Времени потребовалось " << 1000.0 * (stop - start) / CLOCKS_PER_SEC << " ms\n";
		}
		break;
		}
	}
	system("pause");
	return 0;
}

//вывод массива на экран
void showArr(int arr[], int arrSize)
{
	for (int i = 0; i < arrSize; i++)
	{
		cout << setw(6) << arr[i];
		if ((i + 1) % 10 == 0)
		{
			cout << endl;
		}
	}
	cout << endl;
}
// линейный поиск
int linSearch(int arr[], int requiredKey, int arrSize)
{
	int i = 0;
	for (; i < arrSize; i++)
	{
		if (arr[i] == requiredKey)
		{
			cout << "Поиск завершен!" << endl;
			cout << "Количество обработанных элементов: " << (i + 1) << endl;
			return i;
		}
			
	}
	cout << "Поиск завершен!" << endl;
	cout << "Количество обработанных элементов: " << (i+1) << endl;
	return -1;
}
// двоичный поиска 
int Search_Binary(int arr[], int left, int right, int key)
{
	int midd = 0;
	int i = 0;
	while (true)
	{
		midd = (left + right) / 2;

		if (key < arr[midd])       // если искомое меньше значения в ячейке
			right = midd - 1;      // смещаем правую границу поиска
		else if (key > arr[midd])  // если искомое больше значения в ячейке
			left = midd + 1;    // смещаем левую границу поиска
		else                       // иначе (значения равны)
		{
			cout << "Поиск завершен!" << endl;
			cout << "Количество обработанных элементов: " << (i+1) << endl;
			return midd;           // функция возвращает индекс ячейки
		}
			

		if (left > right)          // если границы сомкнулись 
		{
			cout << "Поиск завершен!" << endl;
			cout << "Количество обработанных элементов: " << (i + 1) << endl;
			return -1;
		}
		i++;
	}
}
// 
//функция, выполняющая интерполирующий поиск
//в качесте аргументов принимает массив, размер массива и ключ поиска
int interpolatingSearch(int a[], int arraySize, int keyOfSearch)
{
	//объявляем необходимые локальные переменные
	//изначально устанавливаем нижний индекс на начало массива,
	//а верний на конец массива
	int low = 0;
	int high = arraySize - 1;
	int mid;
	//цикл интерполирующего поиска
	int countIt = 0;
	while (a[low] < keyOfSearch && a[high] >= keyOfSearch)
	{
		//интерполирующий поиск производит оценку новой области поиска
		//по расстоянию между ключом поиска и текущим значение элемента
		mid = low + ((keyOfSearch - a[low]) * (high - low)) / (a[high] - a[low]);
		//если значение в ячейке с индексом mid меньше, то смещаем нижнюю границу
		if (a[mid] < keyOfSearch)
			low = mid + 1;
		//в случае, если значение больше, то смещаем верхнюю границу
		else if (a[mid] > keyOfSearch)
			high = mid - 1;
		//если равны, то возвращаем индекс
		else
		{
			cout << "Поиск завершен!" << endl;
			return mid;
		}		
		countIt++;
	}
	//если цикл while не вернул индекс искомого значения,
	//то проверяем не находится ли оно в ячейке массива с индексом low,
	//иначе возвращаем -1 (значение не найдено)
	if (a[low] == keyOfSearch)
	{
		cout << "Поиск завершен!" << endl;
		cout << "Количество обработанных элементов: " << (countIt + 1) << endl;
		return low;
	}
	else
	{
		cout << "Поиск завершен!" << endl;
		cout << "Количество обработанных элементов: " << (countIt + 1) << endl;
		return -1;
	}
}