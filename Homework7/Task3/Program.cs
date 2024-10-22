/* Задача 3: Задайте произвольный массив. Выведете
его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.
Пример
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 */

// Метод для создания массива

int[] GetArrayRndInt(int sizeArray, int minValue, int maxValue)
{
    int[] rndArray = new int[sizeArray];
    Random rnd = new Random();

    for (int i = 0; i < rndArray.Length; i++)
    {
        rndArray[i] = rnd.Next(minValue, maxValue);
    }
    return rndArray;
}

// Метод для печати массива

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

// Метод для вывода элементов с конца массива (рекурсия)

void PrintNumOfArrayEndToBegin(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }

    Console.Write(array[index]);

    if (index > 0)
    {
        Console.Write(", ");
    }
    PrintNumOfArrayEndToBegin(array, index - 1);

}

// Основная программа

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = GetArrayRndInt(size, 0, 9);
PrintArray(arr);
Console.Write(" => ");
PrintNumOfArrayEndToBegin(arr, size - 1);