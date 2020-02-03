#include <algorithm> // для std::swap. В C++11 используйте заголовок <utility>
#include <iostream>

int main()
{
	setlocale(LC_ALL, "ru");
	const int length = 9;
	char array[length] = { 'b', 'k', 'a', 'd', 'c', 'g','a', 'b','u'};
	std::cout << "Исходный массив символов: ";
	for (int index = 0; index < length; ++index)
		std::cout << array[index] << ' ';
	std::cout << std::endl;
	// Перебираем каждый элемент массива
	// (кроме последнего, он уже будет отсортирован к тому времени, когда мы до него доберемся)
	for (int startIndex = 0; startIndex < length - 1; ++startIndex)
	{
		// В переменной smallestIndex хранится индекс наименьшего значения, которое мы нашли в этой итерации
		// Начинаем с того, что наименьший элемент в этой итерации - это первый элемент (индекс 0)
		int smallestIndex = startIndex;

		// Затем ищем элемент поменьше в остальной части массива
		for (int currentIndex = startIndex + 1; currentIndex < length; ++currentIndex)
		{
			// Если мы нашли элемент, который меньше нашего наименьшего элемента
			if (array[currentIndex] < array[smallestIndex])
				// запоминаем его
				smallestIndex = currentIndex;
		}

		// smallestIndex теперь наименьший элемент 
				// меняем местами наше начальное наименьшее число с тем, которое мы обнаружили
		std::swap(array[startIndex], array[smallestIndex]);
	}

	// Теперь, когда весь массив отсортирован - выводим его на экран
	std::cout << "Массив после сортировки методом выбора: ";
	for (int index = 0; index < length; ++index)
		std::cout << array[index] << ' ';

	system("pause");
	return 0;
}