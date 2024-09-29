﻿/* Описание: Задайте массив из 10 элементов, заполненный числами от -10 до 10.
Замените отрицательные числа на их абсолютные значения, а положительные числа
на их отрицательные эквиваленты. */

Console.Write("Введите массив из десяти чисел от -10 до 10 через зарятую: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), Convert.ToInt32);
// Строчку выше посмотрел в инете, введенные числа разделяются пробелом, конвертируются в int, сохраняются в массив.

for (int i = 0; i < array.Length; i++)
{
    if (array.Length != 10 || array[i] <= -11 || array[i] >= 11) // проверка вводимого массива чисел требованиям условия
    {
        Console.WriteLine("Ошибка ввода!");
        break;
    }

    else
    {
        array[i] *= -1;

        if (i == 0)
        {
            Console.Write("[");
        }

        if (i != array.Length - 1) // убирает пробел после последней цифры
        {
            Console.Write(array[i] + " ");
        }

        else
        {
            Console.Write(array[i] + "]");
        }
    }
}
