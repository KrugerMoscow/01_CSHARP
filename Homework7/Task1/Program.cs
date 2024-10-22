/* Задача 1: Вывод натуральных чисел в промежутке от M до N
Описание: Напишите программу, которая выведет все натуральные числа в
промежутке от M до N. Используйте рекурсию и не используйте циклы.
Пример:
● Вход: M = 1, N = 5
● Выход: 1, 2, 3, 4, 5
● Вход: M = 4, N = 8
● Выход: 4, 5, 6, 7, 8
 */

// using System;
// using Internal;

// Метод для создания чисел M и N

int GetRandomNumInt(int minNum, int maxNum)
{
    Random rnd = new Random();
    int num = rnd.Next(minNum, maxNum);
    return num;
}

// Метод для вывода чисел от M до N

void PrintNumsFromMToN(int numFirst, int numSecond)
{
    if (numFirst < numSecond)
    {
        if (numFirst == numSecond)
        {
            Console.Write(numSecond);
            return;
        }

        Console.Write($"{numFirst},");
        PrintNumsFromMToN(numFirst + 1, numSecond);
    }
    else
    {
        if (numFirst == numSecond)
        {
            Console.Write(numSecond);
            return;
        }

        Console.Write($"{numFirst},");
        PrintNumsFromMToN(numFirst - 1, numSecond);
    }
}


// Основная программа

int numM = GetRandomNumInt(0, 10);
int numN = GetRandomNumInt(0, 10);

Console.Write($"M = {numM}; N = {numN}; => ");
PrintNumsFromMToN(numM, numN);