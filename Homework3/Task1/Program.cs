/* Задание 1: Поиск элемента в массиве
Описание: Задайте массив целых чисел. Напишите программу, которая проверяет,
присутствует ли заданное число в массиве. Программа должна вывести:
Присутствует/Не присутствует. */


Console.Write("Введите массив чисел через пробел: ");
// посмотрел в интернете, считывает числа, отделяет пробелы, конвертирует в int, сохраняет в массив
int[] array = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32); 

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool isExistNum = false; // Логический оператор для вывода ответа в консоль

for (int i = 0; i < array.Length; i++)
{
    if (num == array[i])
    {
        isExistNum = true;
        break;
    }
}

Console.Write($"Число {num} ");
Console.Write(isExistNum ? "присутствует" : "не присутствует");
Console.Write($" в массиве.");
