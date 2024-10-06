/* Задача 2: Задайте массив заполненный случайными
трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в
массиве.

Пример
[344 452 341 125] => 2 */

// Метод создания массива, заполненного случайными числами

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

// Метод для подсчет четных чисел в массиве

int CountEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Метод вывода массива в консоль

void PrintArray (int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length-1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }

    Console.Write("]");
}

// Основная программа

Console.Write("Задайте размер массива: ");
int input = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(input,100, 1000); // вызов метода
int result = CountEvenNumbers(arr); // вызов метода

Console.Write("Количество четных чисел в массиве ");
PrintArray(arr);
Console.Write($": {result}");
