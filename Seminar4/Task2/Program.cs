/* Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2 */

// Все методы создаются в одном месте, либо наверху, либо внизу
// Метод для создания массива из случайных чисел

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

// Метод для печати массива

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

// Метод для подсчета чисел, заканчивающихся на 1 и делящихся на 7

int CountNumsLastADevB(int[] array, int aLast, int bDev)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == aLast && array[i] % bDev == 0) // Остаток от деления на 10 равен aLast и при делении на bDev нет дробной части
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine()); // локальные и глобальные переменные не должны совпадать

// Вызов методов

int[] arr = CreateArrayRndInt(numberN, 1, 100);
PrintArray(arr);

int result = CountNumsLastADevB(arr, 1, 7);
Console.Write($" => {result}");